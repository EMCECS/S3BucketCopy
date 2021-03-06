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
namespace S3BucketCopy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bufferSizeCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accessKeyText = new System.Windows.Forms.TextBox();
            this.secretKeyText = new System.Windows.Forms.TextBox();
            this.endpointText = new System.Windows.Forms.TextBox();
            this.sourceBucketText = new System.Windows.Forms.TextBox();
            this.targetBucketText = new System.Windows.Forms.TextBox();
            this.threadCountText = new System.Windows.Forms.TextBox();
            this.bufferSizeText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.minThreadCheck = new System.Windows.Forms.CheckBox();
            this.maxConnectionCheck = new System.Windows.Forms.CheckBox();
            this.maxConnectionText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentThreads = new System.Windows.Forms.Label();
            this.threadUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.useVhostCheck = new System.Windows.Forms.CheckBox();
            this.startMarkerCheck = new System.Windows.Forms.CheckBox();
            this.useIfNoneMatch = new System.Windows.Forms.CheckBox();
            this.markerText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access Key ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secret Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endpoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Source Bucket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Target Bucket";
            // 
            // bufferSizeCheck
            // 
            this.bufferSizeCheck.AutoSize = true;
            this.bufferSizeCheck.Location = new System.Drawing.Point(13, 632);
            this.bufferSizeCheck.Name = "bufferSizeCheck";
            this.bufferSizeCheck.Size = new System.Drawing.Size(77, 17);
            this.bufferSizeCheck.TabIndex = 5;
            this.bufferSizeCheck.Text = "Buffer Size";
            this.bufferSizeCheck.UseVisualStyleBackColor = true;
            this.bufferSizeCheck.Visible = false;
            this.bufferSizeCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Min Thread Count";
            // 
            // accessKeyText
            // 
            this.accessKeyText.Location = new System.Drawing.Point(127, 10);
            this.accessKeyText.Name = "accessKeyText";
            this.accessKeyText.Size = new System.Drawing.Size(196, 20);
            this.accessKeyText.TabIndex = 8;
            // 
            // secretKeyText
            // 
            this.secretKeyText.Location = new System.Drawing.Point(127, 36);
            this.secretKeyText.Name = "secretKeyText";
            this.secretKeyText.Size = new System.Drawing.Size(196, 20);
            this.secretKeyText.TabIndex = 9;
            // 
            // endpointText
            // 
            this.endpointText.Location = new System.Drawing.Point(127, 61);
            this.endpointText.Name = "endpointText";
            this.endpointText.Size = new System.Drawing.Size(196, 20);
            this.endpointText.TabIndex = 10;
            // 
            // sourceBucketText
            // 
            this.sourceBucketText.Location = new System.Drawing.Point(127, 111);
            this.sourceBucketText.Name = "sourceBucketText";
            this.sourceBucketText.Size = new System.Drawing.Size(196, 20);
            this.sourceBucketText.TabIndex = 11;
            // 
            // targetBucketText
            // 
            this.targetBucketText.Location = new System.Drawing.Point(127, 134);
            this.targetBucketText.Name = "targetBucketText";
            this.targetBucketText.Size = new System.Drawing.Size(196, 20);
            this.targetBucketText.TabIndex = 12;
            // 
            // threadCountText
            // 
            this.threadCountText.Location = new System.Drawing.Point(127, 219);
            this.threadCountText.Name = "threadCountText";
            this.threadCountText.Size = new System.Drawing.Size(196, 20);
            this.threadCountText.TabIndex = 13;
            this.threadCountText.Text = "25";
            // 
            // bufferSizeText
            // 
            this.bufferSizeText.Location = new System.Drawing.Point(127, 630);
            this.bufferSizeText.Name = "bufferSizeText";
            this.bufferSizeText.Size = new System.Drawing.Size(100, 20);
            this.bufferSizeText.TabIndex = 14;
            this.bufferSizeText.Text = "131072";
            this.bufferSizeText.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.outputText);
            this.groupBox1.Location = new System.Drawing.Point(13, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 303);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(3, 20);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(439, 277);
            this.outputText.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 293);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // minThreadCheck
            // 
            this.minThreadCheck.AutoSize = true;
            this.minThreadCheck.Checked = true;
            this.minThreadCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minThreadCheck.Location = new System.Drawing.Point(13, 222);
            this.minThreadCheck.Name = "minThreadCheck";
            this.minThreadCheck.Size = new System.Drawing.Size(15, 14);
            this.minThreadCheck.TabIndex = 17;
            this.minThreadCheck.UseVisualStyleBackColor = true;
            // 
            // maxConnectionCheck
            // 
            this.maxConnectionCheck.AutoSize = true;
            this.maxConnectionCheck.Location = new System.Drawing.Point(13, 248);
            this.maxConnectionCheck.Name = "maxConnectionCheck";
            this.maxConnectionCheck.Size = new System.Drawing.Size(15, 14);
            this.maxConnectionCheck.TabIndex = 20;
            this.maxConnectionCheck.UseVisualStyleBackColor = true;
            // 
            // maxConnectionText
            // 
            this.maxConnectionText.Location = new System.Drawing.Point(127, 245);
            this.maxConnectionText.Name = "maxConnectionText";
            this.maxConnectionText.Size = new System.Drawing.Size(196, 20);
            this.maxConnectionText.TabIndex = 19;
            this.maxConnectionText.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Max Connections";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "default: 50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 632);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "default: 8192";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "default: CPUs";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.currentThreads);
            this.groupBox2.Location = new System.Drawing.Point(333, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 68);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Threads";
            // 
            // currentThreads
            // 
            this.currentThreads.AutoSize = true;
            this.currentThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentThreads.Location = new System.Drawing.Point(7, 26);
            this.currentThreads.Name = "currentThreads";
            this.currentThreads.Size = new System.Drawing.Size(0, 24);
            this.currentThreads.TabIndex = 0;
            // 
            // threadUpdateTimer
            // 
            this.threadUpdateTimer.Enabled = true;
            this.threadUpdateTimer.Interval = 2000;
            this.threadUpdateTimer.Tick += new System.EventHandler(this.threadUpdateTimer_Tick);
            // 
            // useVhostCheck
            // 
            this.useVhostCheck.AutoSize = true;
            this.useVhostCheck.Location = new System.Drawing.Point(127, 88);
            this.useVhostCheck.Name = "useVhostCheck";
            this.useVhostCheck.Size = new System.Drawing.Size(113, 17);
            this.useVhostCheck.TabIndex = 25;
            this.useVhostCheck.Text = "use vhost buckets";
            this.useVhostCheck.UseVisualStyleBackColor = true;
            // 
            // startMarkerCheck
            // 
            this.startMarkerCheck.AutoSize = true;
            this.startMarkerCheck.Location = new System.Drawing.Point(14, 162);
            this.startMarkerCheck.Name = "startMarkerCheck";
            this.startMarkerCheck.Size = new System.Drawing.Size(107, 17);
            this.startMarkerCheck.TabIndex = 26;
            this.startMarkerCheck.Text = "Start from Marker";
            this.startMarkerCheck.UseVisualStyleBackColor = true;
            // 
            // useIfNoneMatch
            // 
            this.useIfNoneMatch.AutoSize = true;
            this.useIfNoneMatch.Location = new System.Drawing.Point(13, 192);
            this.useIfNoneMatch.Name = "useIfNoneMatch";
            this.useIfNoneMatch.Size = new System.Drawing.Size(306, 17);
            this.useIfNoneMatch.TabIndex = 27;
            this.useIfNoneMatch.Text = "Use If-None-Match to check if objects already exist (slower)";
            this.useIfNoneMatch.UseVisualStyleBackColor = true;
            // 
            // markerText
            // 
            this.markerText.Location = new System.Drawing.Point(125, 160);
            this.markerText.Name = "markerText";
            this.markerText.Size = new System.Drawing.Size(196, 20);
            this.markerText.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 652);
            this.Controls.Add(this.markerText);
            this.Controls.Add(this.useIfNoneMatch);
            this.Controls.Add(this.startMarkerCheck);
            this.Controls.Add(this.useVhostCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxConnectionCheck);
            this.Controls.Add(this.maxConnectionText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minThreadCheck);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bufferSizeText);
            this.Controls.Add(this.threadCountText);
            this.Controls.Add(this.targetBucketText);
            this.Controls.Add(this.sourceBucketText);
            this.Controls.Add(this.endpointText);
            this.Controls.Add(this.secretKeyText);
            this.Controls.Add(this.accessKeyText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bufferSizeCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "S3 Bucket Copy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox bufferSizeCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accessKeyText;
        private System.Windows.Forms.TextBox secretKeyText;
        private System.Windows.Forms.TextBox endpointText;
        private System.Windows.Forms.TextBox sourceBucketText;
        private System.Windows.Forms.TextBox targetBucketText;
        private System.Windows.Forms.TextBox threadCountText;
        private System.Windows.Forms.TextBox bufferSizeText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox minThreadCheck;
        private System.Windows.Forms.CheckBox maxConnectionCheck;
        private System.Windows.Forms.TextBox maxConnectionText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label currentThreads;
        private System.Windows.Forms.Timer threadUpdateTimer;
        private System.Windows.Forms.CheckBox useVhostCheck;
        private System.Windows.Forms.CheckBox startMarkerCheck;
        private System.Windows.Forms.CheckBox useIfNoneMatch;
        private System.Windows.Forms.TextBox markerText;
    }
}

