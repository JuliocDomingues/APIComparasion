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
            // btnCenterFace
            // 
            this.btnCenterFace.Location = new System.Drawing.Point(654, 12);
            this.btnCenterFace.Name = "btnCenterFace";
            this.btnCenterFace.Size = new System.Drawing.Size(186, 28);
            this.btnCenterFace.TabIndex = 2;
            this.btnCenterFace.Text = "CenterFaceDotNet";
            this.btnCenterFace.UseVisualStyleBackColor = true;
            this.btnCenterFace.Click += new System.EventHandler(this.btnCenterFace_Click);
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(654, 79);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(186, 182);
            this.picFace.TabIndex = 3;
            this.picFace.TabStop = false;
            // 
            // btnEmgu
            // 
            this.btnEmgu.Location = new System.Drawing.Point(654, 46);
            this.btnEmgu.Name = "btnEmgu";
            this.btnEmgu.Size = new System.Drawing.Size(186, 27);
            this.btnEmgu.TabIndex = 4;
            this.btnEmgu.Text = "EmguCV";
            this.btnEmgu.UseVisualStyleBackColor = true;
            this.btnEmgu.Click += new System.EventHandler(this.btnEmgu_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(654, 461);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(186, 26);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 499);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEmgu);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.btnCenterFace);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCenterFace;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Button btnEmgu;
        private System.Windows.Forms.Button btnReset;
    }
}

