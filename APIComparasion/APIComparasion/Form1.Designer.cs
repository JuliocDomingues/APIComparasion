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
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCenterFace = new System.Windows.Forms.Button();
            this.picFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(4, 1);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(644, 495);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(654, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(186, 29);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnCenterFace
            // 
            this.btnCenterFace.Location = new System.Drawing.Point(654, 47);
            this.btnCenterFace.Name = "btnCenterFace";
            this.btnCenterFace.Size = new System.Drawing.Size(186, 28);
            this.btnCenterFace.TabIndex = 2;
            this.btnCenterFace.Text = "CenterFaceDotNet";
            this.btnCenterFace.UseVisualStyleBackColor = true;
            this.btnCenterFace.Click += new System.EventHandler(this.btnCenterFace_Click);
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(655, 81);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(185, 182);
            this.picFace.TabIndex = 3;
            this.picFace.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 499);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.btnCenterFace);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCenterFace;
        private System.Windows.Forms.PictureBox picFace;
    }
}

