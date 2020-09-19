namespace PaCo_Converter
{
    partial class formAbout
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
            this.lblAboutAppName = new System.Windows.Forms.Label();
            this.lblAboutAppVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutAppName
            // 
            this.lblAboutAppName.AutoSize = true;
            this.lblAboutAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAboutAppName.Location = new System.Drawing.Point(0, 0);
            this.lblAboutAppName.MinimumSize = new System.Drawing.Size(432, 132);
            this.lblAboutAppName.Name = "lblAboutAppName";
            this.lblAboutAppName.Size = new System.Drawing.Size(432, 132);
            this.lblAboutAppName.TabIndex = 0;
            this.lblAboutAppName.Text = "PaCo Converter";
            this.lblAboutAppName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAboutAppVersion
            // 
            this.lblAboutAppVersion.AutoSize = true;
            this.lblAboutAppVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAboutAppVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutAppVersion.Location = new System.Drawing.Point(0, 135);
            this.lblAboutAppVersion.MinimumSize = new System.Drawing.Size(432, 132);
            this.lblAboutAppVersion.Name = "lblAboutAppVersion";
            this.lblAboutAppVersion.Size = new System.Drawing.Size(432, 132);
            this.lblAboutAppVersion.TabIndex = 1;
            this.lblAboutAppVersion.Text = "version";
            this.lblAboutAppVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(436, 267);
            this.Controls.Add(this.lblAboutAppVersion);
            this.Controls.Add(this.lblAboutAppName);
            this.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutAppName;
        private System.Windows.Forms.Label lblAboutAppVersion;
    }
}