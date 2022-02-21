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
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(3, 1);
            this.picCapture.Margin = new System.Windows.Forms.Padding(2);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(483, 402);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btnCenterFace
            // 
            this.btnCenterFace.Location = new System.Drawing.Point(490, 10);
            this.btnCenterFace.Margin = new System.Windows.Forms.Padding(2);
            this.btnCenterFace.Name = "btnCenterFace";
            this.btnCenterFace.Size = new System.Drawing.Size(140, 23);
            this.btnCenterFace.TabIndex = 2;
            this.btnCenterFace.Text = "CenterFaceDotNet";
            this.btnCenterFace.UseVisualStyleBackColor = true;
            this.btnCenterFace.Click += new System.EventHandler(this.btnCenterFace_Click);
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(490, 64);
            this.picFace.Margin = new System.Windows.Forms.Padding(2);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(140, 148);
            this.picFace.TabIndex = 3;
            this.picFace.TabStop = false;
            // 
            // btnEmgu
            // 
            this.btnEmgu.Location = new System.Drawing.Point(490, 37);
            this.btnEmgu.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmgu.Name = "btnEmgu";
            this.btnEmgu.Size = new System.Drawing.Size(140, 22);
            this.btnEmgu.TabIndex = 4;
            this.btnEmgu.Text = "EmguCV";
            this.btnEmgu.UseVisualStyleBackColor = true;
            this.btnEmgu.Click += new System.EventHandler(this.btnEmgu_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(490, 375);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 21);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(491, 218);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(35, 13);
            this.totalTime.TabIndex = 8;
            this.totalTime.Text = "Total time: 0 ms";
            // 
            // detectionTime
            // 
            this.detectionTime.AutoSize = true;
            this.detectionTime.Location = new System.Drawing.Point(491, 237);
            this.detectionTime.Name = "detectionTime";
            this.detectionTime.Size = new System.Drawing.Size(81, 13);
            this.detectionTime.TabIndex = 6;
            this.detectionTime.Text = "Detection: 0 ms";
            // 
            // drawingTime
            // 
            this.drawingTime.AutoSize = true;
            this.drawingTime.Location = new System.Drawing.Point(491, 256);
            this.drawingTime.Name = "drawingTime";
            this.drawingTime.Size = new System.Drawing.Size(74, 13);
            this.drawingTime.TabIndex = 7;
            this.drawingTime.Text = "Drawing: 0 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 405);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.drawingTime);
            this.Controls.Add(this.detectionTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEmgu);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.btnCenterFace);
            this.Controls.Add(this.picCapture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
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
    }
}

