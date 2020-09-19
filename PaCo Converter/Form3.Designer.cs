namespace PaCo_Converter
{
    partial class formZonaRacLac
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
            this.radioGprs = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radio3gpp = new System.Windows.Forms.RadioButton();
            this.bntCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioGprs
            // 
            this.radioGprs.AutoSize = true;
            this.radioGprs.Location = new System.Drawing.Point(16, 39);
            this.radioGprs.Name = "radioGprs";
            this.radioGprs.Size = new System.Drawing.Size(48, 17);
            this.radioGprs.TabIndex = 0;
            this.radioGprs.Text = ".gprs";
            this.radioGprs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a Zona DNS correta";
            // 
            // radio3gpp
            // 
            this.radio3gpp.AutoSize = true;
            this.radio3gpp.Location = new System.Drawing.Point(16, 62);
            this.radio3gpp.Name = "radio3gpp";
            this.radio3gpp.Size = new System.Drawing.Size(108, 17);
            this.radio3gpp.TabIndex = 2;
            this.radio3gpp.TabStop = true;
            this.radio3gpp.Text = ".3gppnetwork.org";
            this.radio3gpp.UseVisualStyleBackColor = true;
            // 
            // bntCancel
            // 
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancel.Location = new System.Drawing.Point(16, 106);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 3;
            this.bntCancel.Text = "Cancelar";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.BntCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(97, 106);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // formZonaRacLac
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntCancel;
            this.ClientSize = new System.Drawing.Size(190, 148);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.radio3gpp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioGprs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formZonaRacLac";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar Zona RAC / LAC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormZonaRacLac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioGprs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio3gpp;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button btnOk;
    }
}