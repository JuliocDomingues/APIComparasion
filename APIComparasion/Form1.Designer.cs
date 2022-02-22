namespace APIComparasion
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btnCenterFace = new System.Windows.Forms.Button();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.btnEmgu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.detectionTime = new System.Windows.Forms.Label();
            this.drawingTime = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.scaleFactor = new System.Windows.Forms.NumericUpDown();
            this.neighbors = new System.Windows.Forms.NumericUpDown();
            this.scaleFactorLbl = new System.Windows.Forms.Label();
            this.neighborsLbl = new System.Windows.Forms.Label();
            this.btnFaceRecognition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighbors)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(4, 1);
            this.picCapture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(741, 597);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btnCenterFace
            // 
            this.btnCenterFace.Location = new System.Drawing.Point(751, 39);
            this.btnCenterFace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCenterFace.Name = "btnCenterFace";
            this.btnCenterFace.Size = new System.Drawing.Size(187, 28);
            this.btnCenterFace.TabIndex = 2;
            this.btnCenterFace.Text = "CenterFaceDotNet";
            this.btnCenterFace.UseVisualStyleBackColor = true;
            this.btnCenterFace.Click += new System.EventHandler(this.btnCenterFace_Click);
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(751, 102);
            this.picFace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(187, 182);
            this.picFace.TabIndex = 3;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // btnEmgu
            // 
            this.btnEmgu.Location = new System.Drawing.Point(751, 71);
            this.btnEmgu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmgu.Name = "btnEmgu";
            this.btnEmgu.Size = new System.Drawing.Size(187, 27);
            this.btnEmgu.TabIndex = 4;
            this.btnEmgu.Text = "EmguCV";
            this.btnEmgu.UseVisualStyleBackColor = true;
            this.btnEmgu.Click += new System.EventHandler(this.btnEmgu_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(751, 562);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(187, 26);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // detectionTime
            // 
            this.detectionTime.AutoSize = true;
            this.detectionTime.Location = new System.Drawing.Point(748, 318);
            this.detectionTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectionTime.Name = "detectionTime";
            this.detectionTime.Size = new System.Drawing.Size(98, 16);
            this.detectionTime.TabIndex = 6;
            this.detectionTime.Text = "Detection: 0 ms";
            // 
            // drawingTime
            // 
            this.drawingTime.AutoSize = true;
            this.drawingTime.Location = new System.Drawing.Point(748, 334);
            this.drawingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawingTime.Name = "drawingTime";
            this.drawingTime.Size = new System.Drawing.Size(90, 16);
            this.drawingTime.TabIndex = 7;
            this.drawingTime.Text = "Drawing: 0 ms";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(748, 302);
            this.totalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(100, 16);
            this.totalTime.TabIndex = 8;
            this.totalTime.Text = "Total time: 0 ms";
            // 
            // scaleFactor
            // 
            this.scaleFactor.DecimalPlaces = 1;
            this.scaleFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleFactor.Location = new System.Drawing.Point(843, 504);
            this.scaleFactor.Margin = new System.Windows.Forms.Padding(4);
            this.scaleFactor.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.scaleFactor.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(64, 22);
            this.scaleFactor.TabIndex = 9;
            this.scaleFactor.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.scaleFactor.Visible = false;
            // 
            // neighbors
            // 
            this.neighbors.Location = new System.Drawing.Point(843, 534);
            this.neighbors.Margin = new System.Windows.Forms.Padding(4);
            this.neighbors.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.neighbors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighbors.Name = "neighbors";
            this.neighbors.Size = new System.Drawing.Size(64, 22);
            this.neighbors.TabIndex = 10;
            this.neighbors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighbors.Visible = false;
            // 
            // scaleFactorLbl
            // 
            this.scaleFactorLbl.AutoSize = true;
            this.scaleFactorLbl.Location = new System.Drawing.Point(752, 504);
            this.scaleFactorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scaleFactorLbl.Name = "scaleFactorLbl";
            this.scaleFactorLbl.Size = new System.Drawing.Size(83, 16);
            this.scaleFactorLbl.TabIndex = 11;
            this.scaleFactorLbl.Text = "Scale Factor";
            this.scaleFactorLbl.Visible = false;
            // 
            // neighborsLbl
            // 
            this.neighborsLbl.AutoSize = true;
            this.neighborsLbl.Location = new System.Drawing.Point(752, 534);
            this.neighborsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.neighborsLbl.Name = "neighborsLbl";
            this.neighborsLbl.Size = new System.Drawing.Size(70, 16);
            this.neighborsLbl.TabIndex = 12;
            this.neighborsLbl.Text = "Neighbors";
            this.neighborsLbl.Visible = false;
            // 
            // btnFaceRecognition
            // 
            this.btnFaceRecognition.Location = new System.Drawing.Point(751, 6);
            this.btnFaceRecognition.Name = "btnFaceRecognition";
            this.btnFaceRecognition.Size = new System.Drawing.Size(187, 28);
            this.btnFaceRecognition.TabIndex = 13;
            this.btnFaceRecognition.Text = "FaceRecognition";
            this.btnFaceRecognition.UseVisualStyleBackColor = true;
            this.btnFaceRecognition.Click += new System.EventHandler(this.btnFaceRecognition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 599);
            this.Controls.Add(this.btnFaceRecognition);
            this.Controls.Add(this.neighborsLbl);
            this.Controls.Add(this.scaleFactorLbl);
            this.Controls.Add(this.neighbors);
            this.Controls.Add(this.scaleFactor);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.drawingTime);
            this.Controls.Add(this.detectionTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEmgu);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.btnCenterFace);
            this.Controls.Add(this.picCapture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighbors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCenterFace;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Button btnEmgu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label detectionTime;
        private System.Windows.Forms.Label drawingTime;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.NumericUpDown scaleFactor;
        private System.Windows.Forms.NumericUpDown neighbors;
        private System.Windows.Forms.Label scaleFactorLbl;
        private System.Windows.Forms.Label neighborsLbl;
        private System.Windows.Forms.Button btnFaceRecognition;
    }
}

