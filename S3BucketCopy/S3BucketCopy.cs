﻿/**
Copyright (c) 2016 EMC Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy of this 
software and associated documentation files (the "Software"), to deal in the Software 
without restriction, including without limitation the rights to use, copy, modify, 
merge, publish, distribute, sublicense, and/or sell copies of the Software, and to 
permit persons to whom the Software is furnished to do so, subject to the following 
conditions:

The above copyright notice and this permission notice shall be included in all copies 
or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR 
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace S3BucketCopy
{
    class S3BucketCopy
    {
        private DateTime startTime;

        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Endpoint { get; set; }
        public int BufferSize { get; set; }
        public int MinThreads { get; set; }
        public int MaxConnections { get; set; }
        public Form1 Parent { set; get; }
        public bool UseVhostBuckets { get; set; }
        public bool NoCleanup { get; set; }
        public string SourceBucket { get; set; }
        public string TargetBucket { get; set; }
        public string StartMarker { get; set; }
        public bool UseIfNoneMatch { set; get; }

        public int FailureCount { get { return failureCount; } }
        private int failureCount;
        public int SuccessCount { get { return successCount; } }
        private int successCount;
        public int SkippedCount { get { return skippedCount; } }
        private int skippedCount;


        public TimeSpan Duration { get; private set; }

        private delegate ListObjectsResponse ListObjectsDelegate(string bucketName, string marker);

        AmazonS3Client s3;

        public S3BucketCopy()
        {
            BufferSize = -1;
            successCount = 0;
            failureCount = 0;
            skippedCount = 0;
            MinThreads = -1;
            MaxConnections = -1;
            UseVhostBuckets = false;
        }

        public void Start()
        {
            try
            {
                Parent.LogOutput("Initializing Connection...");
                connect();

                Parent.LogOutput("Checking Buckets...");
                checkBuckets();

                Parent.LogOutput("Copying Objects...");
                startTime = DateTime.Now;
                copyObjects();
                Duration = DateTime.Now - startTime;
                Parent.LogOutput("Copy Complete.");

                printSummary();
            }
            catch (Exception e)
            {
                Parent.LogOutput(string.Format("CRITICAL FAILURE: {0}\r\n{1}", e.Message, e.StackTrace));
            }
        }

        private void connect()
        {
            AmazonS3Config config = new AmazonS3Config()
            {
                ForcePathStyle = (!UseVhostBuckets),
                SignatureVersion = "2",
                ServiceURL = Endpoint
            };
            if (MaxConnections != -1)
            {
                config.ConnectionLimit = MaxConnections;
            }

            if (BufferSize != -1)
            {
                config.BufferSize = BufferSize;
            }
            s3 = new AmazonS3Client(new BasicAWSCredentials(AccessKey, SecretKey), config);

            Parent.LogOutput(string.Format(" - Buffer size is {0} bytes", s3.Config.BufferSize));
            Parent.LogOutput(string.Format(" - Connection limit is {0}", s3.Config.ConnectionLimit));
        }

        private void checkBuckets()
        {
            try
            {
                checkBucketExists(SourceBucket);
            } catch(Exception e)
            {
                throw new Exception(string.Format("Could not list source bucket {0}: {1}", SourceBucket, e.Message));
            }
            try
            {
                checkBucketExists(TargetBucket);
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("Could not list target bucket {0}: {1}", TargetBucket, e.Message));
            }
        }

        /// <summary>
        /// Checks to see if a bucket exists.  This is done by seeing if we can list the bucket.  Other
        /// methods may not work due to permission issues and seeing if it exists in listBuckets isn't
        /// sufficient because you may not own the bucket in question and list buckets only lists the
        /// buckets owned by the caller.  If the bucket does not exist, an exception will be thrown.
        /// </summary>
        /// <param name="bucketName">bucket name to check</param>
        private void checkBucketExists(string bucketName)
        {
            s3.ListObjects(new ListObjectsRequest()
            {
                BucketName = bucketName,
                MaxKeys = 1
            });
        }

        private void copyObjects()
        {
            int workerThreads = 0;
            int ioThreads = 0;
            string marker = StartMarker;

            ThreadPool.GetMinThreads(out workerThreads, out ioThreads);
            Parent.LogOutput(string.Format(" - Min threads: worker: {0} IO: {1}", workerThreads, ioThreads));

            if (MinThreads != -1)
            {
                Parent.LogOutput(string.Format(" -> Setting Min worker threads to {0}", MinThreads));
                bool success = ThreadPool.SetMinThreads(MinThreads, ioThreads);
                if (!success)
                {
                    Parent.LogOutput("  FAILED!");
                }
            }

            ParallelOptions opts = new ParallelOptions();
            // Don't bother forking more threads than connections.
            opts.MaxDegreeOfParallelism = s3.Config.ConnectionLimit;

            ListObjectsResponse resp = null;
            bool moreResults = true;
            do
            {
                if (resp == null)
                {
                    resp = fetchObjectListingSync(SourceBucket, marker);
                }
                marker = resp.NextMarker;

                // If there's more, start fetching the next page of results.
                Task<ListObjectsResponse> t = null;
                if(resp.IsTruncated)
                {
                    t = fetchObjectListing(SourceBucket, marker);
                } else
                {
                    moreResults = false;
                }

                Parallel.ForEach(resp.S3Objects, opts, obj => {
                    try
                    {
                        if(UseIfNoneMatch)
                        {
                            // Actually, can't use If-None-Match on the *target* object yet.  Need to
                            // HEAD the target.
                            try
                            {
                                GetObjectMetadataResponse meta = s3.GetObjectMetadata(TargetBucket, obj.Key);
                                if(meta.ETag.Equals(obj.ETag))
                                {
                                    // Target is same.
                                    Interlocked.Increment(ref skippedCount);
                                    return;
                                }
                            } catch(AmazonS3Exception e)
                            {
                                if(e.StatusCode == System.Net.HttpStatusCode.NotFound)
                                {
                                    // Good!
                                } else
                                {
                                    throw e;
                                }
                            }
                        }
                        CopyObjectRequest req = new CopyObjectRequest()
                        {
                            SourceBucket = SourceBucket,
                            SourceKey = obj.Key,
                            DestinationBucket = TargetBucket,
                            DestinationKey = obj.Key
                        };                      
                        s3.CopyObject(req);
                        
                        Interlocked.Increment(ref successCount);
                    } 
                    catch (AmazonS3Exception e)
                    {
                        if (e.StatusCode == System.Net.HttpStatusCode.PreconditionFailed)
                        {
                            // ETag matched
                            Interlocked.Increment(ref skippedCount);
                        }
                        else
                        {
                            // Some other error.
                            Interlocked.Increment(ref failureCount);
                            Parent.LogOutput(string.Format("Error copying {0}: {1}", obj.Key, e.ToString()));
                        }
                    }
                    catch (Exception e)
                    {
                        Interlocked.Increment(ref failureCount);
                        Parent.LogOutput(string.Format("Error copying {0}: {1}", obj.Key, e.ToString()));
                    }

                });
                if(UseIfNoneMatch)
                {
                    Parent.LogOutput(string.Format(" -- {0} objects copied ({2} skipped). NextMarker = {1}", successCount, marker, skippedCount));
                }
                else
                {
                    Parent.LogOutput(string.Format(" -- {0} objects copied. NextMarker = {1}", successCount, marker));
                }
                if (t != null)
                {
                    t.Wait();
                    resp = t.Result;
                }

            } while (moreResults);
        }

        private async Task<ListObjectsResponse> fetchObjectListing(string bucketName, string marker)
        {
            ListObjectsRequest req = new ListObjectsRequest()
            {
                BucketName = bucketName
            };
            if (marker != null)
            {
                req.Marker = marker;
            }

            return await s3.ListObjectsAsync(req);
        }

        private ListObjectsResponse fetchObjectListingSync(string bucketName, string marker)
        {
            ListObjectsRequest req = new ListObjectsRequest()
            {
                BucketName = bucketName
            };
            if (marker != null)
            {
                req.Marker = marker;
            }

            return s3.ListObjects(req);
        }

        private void printSummary()
        {
            double objPerSec = (double)SuccessCount / Duration.TotalSeconds;
            Parent.LogOutput(string.Format("Copied {0} objects in {1}ms: {2:F2} obj/s, {3} Failures", SuccessCount, Duration.TotalMilliseconds, objPerSec, FailureCount));
        }
    }
}
