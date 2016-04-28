# S3BucketCopy
Windows test app for copying objects from one bucket to another.

This application will copy all objects from the source bucket to the target bucket using the S3 PUT Object - Copy method.  This
does a server-side copy of the data and will be much faster than re-uploading all of the data.  The copy operations will also
be parallelized to get more throughput from ECS.  You can adjust the minimum thread count to boost the initial copy rate, but
the .NET 

More information about using S3 and .NET with EMC ECS can be found on the ECS community: https://community.emc.com/docs/DOC-36774
