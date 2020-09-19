namespace PaCo_Converter
{
    partial class formMCCMNC
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
            this.lblConfMCC = new System.Windows.Forms.Label();
            this.txtBxConfMCC = new System.Windows.Forms.TextBox();
            this.txtBxConfMNC = new System.Windows.Forms.TextBox();
            this.lblConfMNC = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfMCC
            // 
            this.lblConfMCC.AutoSize = true;
            this.lblConfMCC.Location = new System.Drawing.Point(34, 14);
            this.lblConfMCC.Name = "lblConfMCC";
            this.lblConfMCC.Size = new System.Drawing.Size(30, 13);
            this.lblConfMCC.TabIndex = 0;
            this.lblConfMCC.Text = "MCC";
            // 
            // txtBxConfMCC
            // 
            this.txtBxConfMCC.AllowDrop = true;
            this.txtBxConfMCC.Location = new System.Drawing.Point(37, 30);
            this.txtBxConfMCC.MaxLength = 3;
            this.txtBxConfMCC.Name = "txtBxConfMCC";
            this.txtBxConfMCC.Size = new System.Drawing.Size(50, 20);
            this.txtBxConfMCC.TabIndex = 1;
            this.txtBxConfMCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateInteger);
            // 
            // txtBxConfMNC
            // 
            this.txtBxConfMNC.AllowDrop = true;
            this.txtBxConfMNC.Location = new System.Drawing.Point(106, 30);
            this.txtBxConfMNC.MaxLength = 3;
            this.txtBxConfMNC.Name = "txtBxConfMNC";
            this.txtBxConfMNC.Size = new System.Drawing.Size(50, 20);
            this.txtBxConfMNC.TabIndex = 3;
            this.txtBxConfMNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateInteger);
            // 
            // lblConfMNC
            // 
            this.lblConfMNC.AutoSize = true;
            this.lblConfMNC.Location = new System.Drawing.Point(103, 14);
            this.lblConfMNC.Name = "lblConfMNC";
            this.lblConfMNC.Size = new System.Drawing.Size(31, 13);
            this.lblConfMNC.TabIndex = 2;
            this.lblConfMNC.Text = "MNC";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(106, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Button2_Click);
            // 
            // formMCCMNC
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(197, 115);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBxConfMNC);
            this.Controls.Add(this.lblConfMNC);
            this.Controls.Add(this.txtBxConfMCC);
            this.Controls.Add(this.lblConfMCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMCCMNC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar MCC e MNC";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfMCC;
        private System.Windows.Forms.TextBox txtBxConfMCC;
        private System.Windows.Forms.TextBox txtBxConfMNC;
        private System.Windows.Forms.Label lblConfMNC;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}