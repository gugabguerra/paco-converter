namespace PaCo_Converter
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.grpBxHexaDec = new System.Windows.Forms.GroupBox();
            this.lblDec = new System.Windows.Forms.Label();
            this.txtBxDec = new System.Windows.Forms.TextBox();
            this.btnHexaDec = new System.Windows.Forms.Button();
            this.txtBxHexa = new System.Windows.Forms.TextBox();
            this.lblHexa = new System.Windows.Forms.Label();
            this.grpBxRAI = new System.Windows.Forms.GroupBox();
            this.btnRaiDns = new System.Windows.Forms.Button();
            this.lblLAC = new System.Windows.Forms.Label();
            this.txtBxLAC = new System.Windows.Forms.TextBox();
            this.lblRAIDNS = new System.Windows.Forms.Label();
            this.txtBxRAIDNS = new System.Windows.Forms.TextBox();
            this.txtBxRAC = new System.Windows.Forms.TextBox();
            this.lblRAC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTacDns = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxTACDNS = new System.Windows.Forms.TextBox();
            this.txtBxTAC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMCCMNC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZonaRACLAC = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCopyInfo1 = new System.Windows.Forms.Label();
            this.lblCopyInfo2 = new System.Windows.Forms.Label();
            this.lblCopyInfo3 = new System.Windows.Forms.Label();
            this.lblCopyInfo4 = new System.Windows.Forms.Label();
            this.toolTipCopy = new System.Windows.Forms.ToolTip(this.components);
            this.grpBxHexaDec.SuspendLayout();
            this.grpBxRAI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxHexaDec
            // 
            this.grpBxHexaDec.AutoSize = true;
            this.grpBxHexaDec.Controls.Add(this.lblDec);
            this.grpBxHexaDec.Controls.Add(this.txtBxDec);
            this.grpBxHexaDec.Controls.Add(this.btnHexaDec);
            this.grpBxHexaDec.Controls.Add(this.txtBxHexa);
            this.grpBxHexaDec.Controls.Add(this.lblHexa);
            this.grpBxHexaDec.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxHexaDec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxHexaDec.Location = new System.Drawing.Point(0, 24);
            this.grpBxHexaDec.Name = "grpBxHexaDec";
            this.grpBxHexaDec.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.grpBxHexaDec.Size = new System.Drawing.Size(652, 91);
            this.grpBxHexaDec.TabIndex = 0;
            this.grpBxHexaDec.TabStop = false;
            this.grpBxHexaDec.Text = "Hexadecimal p/ Decimal";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDec.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDec.Location = new System.Drawing.Point(236, 18);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(36, 21);
            this.lblDec.TabIndex = 4;
            this.lblDec.Text = "Dec";
            this.toolTipCopy.SetToolTip(this.lblDec, "clique para COPIAR o texto para a área de transferência");
            this.lblDec.Click += new System.EventHandler(this.LblDec_Click);
            // 
            // txtBxDec
            // 
            this.txtBxDec.Location = new System.Drawing.Point(240, 43);
            this.txtBxDec.Name = "txtBxDec";
            this.txtBxDec.Size = new System.Drawing.Size(152, 23);
            this.txtBxDec.TabIndex = 3;
            this.txtBxDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateInteger);
            // 
            // btnHexaDec
            // 
            this.btnHexaDec.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnHexaDec.Location = new System.Drawing.Point(180, 42);
            this.btnHexaDec.Name = "btnHexaDec";
            this.btnHexaDec.Size = new System.Drawing.Size(49, 27);
            this.btnHexaDec.TabIndex = 2;
            this.btnHexaDec.Text = "D";
            this.btnHexaDec.UseVisualStyleBackColor = true;
            this.btnHexaDec.Click += new System.EventHandler(this.BtnHexaDec_Click);
            // 
            // txtBxHexa
            // 
            this.txtBxHexa.Location = new System.Drawing.Point(18, 43);
            this.txtBxHexa.Name = "txtBxHexa";
            this.txtBxHexa.Size = new System.Drawing.Size(152, 23);
            this.txtBxHexa.TabIndex = 1;
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHexa.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexa.Location = new System.Drawing.Point(14, 19);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(44, 21);
            this.lblHexa.TabIndex = 0;
            this.lblHexa.Text = "Hexa";
            this.toolTipCopy.SetToolTip(this.lblHexa, "clique para COPIAR o texto para a área de transferência");
            this.lblHexa.Click += new System.EventHandler(this.LblHexa_Click);
            // 
            // grpBxRAI
            // 
            this.grpBxRAI.AutoSize = true;
            this.grpBxRAI.Controls.Add(this.btnRaiDns);
            this.grpBxRAI.Controls.Add(this.lblLAC);
            this.grpBxRAI.Controls.Add(this.txtBxLAC);
            this.grpBxRAI.Controls.Add(this.lblRAIDNS);
            this.grpBxRAI.Controls.Add(this.txtBxRAIDNS);
            this.grpBxRAI.Controls.Add(this.txtBxRAC);
            this.grpBxRAI.Controls.Add(this.lblRAC);
            this.grpBxRAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxRAI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxRAI.Location = new System.Drawing.Point(0, 115);
            this.grpBxRAI.Name = "grpBxRAI";
            this.grpBxRAI.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.grpBxRAI.Size = new System.Drawing.Size(652, 91);
            this.grpBxRAI.TabIndex = 1;
            this.grpBxRAI.TabStop = false;
            this.grpBxRAI.Text = "RAC / LAC formato DNS";
            // 
            // btnRaiDns
            // 
            this.btnRaiDns.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRaiDns.Location = new System.Drawing.Point(180, 42);
            this.btnRaiDns.Name = "btnRaiDns";
            this.btnRaiDns.Size = new System.Drawing.Size(49, 27);
            this.btnRaiDns.TabIndex = 3;
            this.btnRaiDns.Text = "D";
            this.btnRaiDns.UseVisualStyleBackColor = true;
            this.btnRaiDns.Click += new System.EventHandler(this.BtnRaiDns_Click);
            // 
            // lblLAC
            // 
            this.lblLAC.AutoSize = true;
            this.lblLAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLAC.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAC.Location = new System.Drawing.Point(94, 18);
            this.lblLAC.Name = "lblLAC";
            this.lblLAC.Size = new System.Drawing.Size(37, 21);
            this.lblLAC.TabIndex = 6;
            this.lblLAC.Text = "LAC";
            this.toolTipCopy.SetToolTip(this.lblLAC, "clique para COPIAR o texto para a área de transferência");
            this.lblLAC.Click += new System.EventHandler(this.LblLAC_Click);
            // 
            // txtBxLAC
            // 
            this.txtBxLAC.Location = new System.Drawing.Point(96, 43);
            this.txtBxLAC.MaxLength = 5;
            this.txtBxLAC.Name = "txtBxLAC";
            this.txtBxLAC.Size = new System.Drawing.Size(74, 23);
            this.txtBxLAC.TabIndex = 2;
            this.txtBxLAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateInteger);
            // 
            // lblRAIDNS
            // 
            this.lblRAIDNS.AutoSize = true;
            this.lblRAIDNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRAIDNS.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAIDNS.Location = new System.Drawing.Point(236, 18);
            this.lblRAIDNS.Name = "lblRAIDNS";
            this.lblRAIDNS.Size = new System.Drawing.Size(41, 21);
            this.lblRAIDNS.TabIndex = 4;
            this.lblRAIDNS.Text = "DNS";
            this.toolTipCopy.SetToolTip(this.lblRAIDNS, "clique para COPIAR o texto para a área de transferência");
            this.lblRAIDNS.Click += new System.EventHandler(this.LblRAIDNS_Click);
            // 
            // txtBxRAIDNS
            // 
            this.txtBxRAIDNS.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBxRAIDNS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxRAIDNS.Location = new System.Drawing.Point(240, 42);
            this.txtBxRAIDNS.Name = "txtBxRAIDNS";
            this.txtBxRAIDNS.Size = new System.Drawing.Size(394, 26);
            this.txtBxRAIDNS.TabIndex = 4;
            // 
            // txtBxRAC
            // 
            this.txtBxRAC.Location = new System.Drawing.Point(18, 43);
            this.txtBxRAC.MaxLength = 2;
            this.txtBxRAC.Name = "txtBxRAC";
            this.txtBxRAC.Size = new System.Drawing.Size(74, 23);
            this.txtBxRAC.TabIndex = 1;
            this.txtBxRAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateInteger);
            // 
            // lblRAC
            // 
            this.lblRAC.AutoSize = true;
            this.lblRAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRAC.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAC.Location = new System.Drawing.Point(12, 18);
            this.lblRAC.Name = "lblRAC";
            this.lblRAC.Size = new System.Drawing.Size(39, 21);
            this.lblRAC.TabIndex = 0;
            this.lblRAC.Text = "RAC";
            this.toolTipCopy.SetToolTip(this.lblRAC, "clique para COPIAR o texto para a área de transferência");
            this.lblRAC.Click += new System.EventHandler(this.LblRAC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnTacDns);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBxTACDNS);
            this.groupBox1.Controls.Add(this.txtBxTAC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(652, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAC formato DNS";
            // 
            // btnTacDns
            // 
            this.btnTacDns.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnTacDns.Location = new System.Drawing.Point(180, 41);
            this.btnTacDns.Name = "btnTacDns";
            this.btnTacDns.Size = new System.Drawing.Size(49, 27);
            this.btnTacDns.TabIndex = 2;
            this.btnTacDns.Text = "D";
            this.btnTacDns.UseVisualStyleBackColor = true;
            this.btnTacDns.Click += new System.EventHandler(this.BtnTacDns_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNS";
            this.toolTipCopy.SetToolTip(this.label2, "clique para COPIAR o texto para a área de transferência");
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtBxTACDNS
            // 
            this.txtBxTACDNS.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBxTACDNS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTACDNS.Location = new System.Drawing.Point(240, 42);
            this.txtBxTACDNS.Name = "txtBxTACDNS";
            this.txtBxTACDNS.Size = new System.Drawing.Size(394, 26);
            this.txtBxTACDNS.TabIndex = 3;
            // 
            // txtBxTAC
            // 
            this.txtBxTAC.Location = new System.Drawing.Point(18, 43);
            this.txtBxTAC.MaxLength = 5;
            this.txtBxTAC.Name = "txtBxTAC";
            this.txtBxTAC.Size = new System.Drawing.Size(152, 23);
            this.txtBxTAC.TabIndex = 1;
            this.txtBxTAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateInteger);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "TAC";
            this.toolTipCopy.SetToolTip(this.label3, "clique para COPIAR o texto para a área de transferência");
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMCCMNC,
            this.menuZonaRACLAC});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configurar";
            // 
            // menuMCCMNC
            // 
            this.menuMCCMNC.Name = "menuMCCMNC";
            this.menuMCCMNC.Size = new System.Drawing.Size(180, 22);
            this.menuMCCMNC.Text = "MCC / MNC";
            this.menuMCCMNC.Click += new System.EventHandler(this.MenuMCCMNC_Click);
            // 
            // menuZonaRACLAC
            // 
            this.menuZonaRACLAC.Name = "menuZonaRACLAC";
            this.menuZonaRACLAC.Size = new System.Drawing.Size(180, 22);
            this.menuZonaRACLAC.Text = "Zona RAC / LAC";
            this.menuZonaRACLAC.Click += new System.EventHandler(this.MenuZonaRACLAC_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(516, 475);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(124, 13);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "copyright @gugabguerra";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lblCopyInfo4);
            this.groupBox2.Controls.Add(this.lblCopyInfo3);
            this.groupBox2.Controls.Add(this.lblCopyInfo2);
            this.groupBox2.Controls.Add(this.lblCopyInfo1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(652, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações para Copy/Paste";
            // 
            // lblCopyInfo1
            // 
            this.lblCopyInfo1.AutoSize = true;
            this.lblCopyInfo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyInfo1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyInfo1.Location = new System.Drawing.Point(12, 29);
            this.lblCopyInfo1.Name = "lblCopyInfo1";
            this.lblCopyInfo1.Size = new System.Drawing.Size(322, 21);
            this.lblCopyInfo1.TabIndex = 4;
            this.lblCopyInfo1.Text = "x-3gpp-sgw:x-s11:x-s5-gtp:x-s5-pmip:x-s8-gtp";
            this.toolTipCopy.SetToolTip(this.lblCopyInfo1, "clique para COPIAR o texto para a área de transferência");
            // 
            // lblCopyInfo2
            // 
            this.lblCopyInfo2.AutoSize = true;
            this.lblCopyInfo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyInfo2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyInfo2.Location = new System.Drawing.Point(12, 66);
            this.lblCopyInfo2.Name = "lblCopyInfo2";
            this.lblCopyInfo2.Size = new System.Drawing.Size(136, 21);
            this.lblCopyInfo2.TabIndex = 5;
            this.lblCopyInfo2.Text = "x-3gpp-mme:x-s10";
            this.toolTipCopy.SetToolTip(this.lblCopyInfo2, "clique para COPIAR o texto para a área de transferência");
            // 
            // lblCopyInfo3
            // 
            this.lblCopyInfo3.AutoSize = true;
            this.lblCopyInfo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyInfo3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyInfo3.Location = new System.Drawing.Point(12, 101);
            this.lblCopyInfo3.Name = "lblCopyInfo3";
            this.lblCopyInfo3.Size = new System.Drawing.Size(44, 21);
            this.lblCopyInfo3.TabIndex = 6;
            this.lblCopyInfo3.Text = ".gprs";
            this.toolTipCopy.SetToolTip(this.lblCopyInfo3, "clique para COPIAR o texto para a área de transferência");
            // 
            // lblCopyInfo4
            // 
            this.lblCopyInfo4.AutoSize = true;
            this.lblCopyInfo4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyInfo4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyInfo4.Location = new System.Drawing.Point(12, 135);
            this.lblCopyInfo4.Name = "lblCopyInfo4";
            this.lblCopyInfo4.Size = new System.Drawing.Size(132, 21);
            this.lblCopyInfo4.TabIndex = 7;
            this.lblCopyInfo4.Text = ".3gppnetwork.org";
            this.toolTipCopy.SetToolTip(this.lblCopyInfo4, "clique para COPIAR o texto para a área de transferência");
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxRAI);
            this.Controls.Add(this.grpBxHexaDec);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "PaCo Converter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBxHexaDec.ResumeLayout(false);
            this.grpBxHexaDec.PerformLayout();
            this.grpBxRAI.ResumeLayout(false);
            this.grpBxRAI.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxHexaDec;
        private System.Windows.Forms.Button btnHexaDec;
        private System.Windows.Forms.TextBox txtBxHexa;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.TextBox txtBxDec;
        private System.Windows.Forms.GroupBox grpBxRAI;
        private System.Windows.Forms.Label lblRAIDNS;
        private System.Windows.Forms.TextBox txtBxRAC;
        private System.Windows.Forms.Label lblRAC;
        private System.Windows.Forms.Label lblLAC;
        private System.Windows.Forms.TextBox txtBxLAC;
        private System.Windows.Forms.TextBox txtBxRAIDNS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxTACDNS;
        private System.Windows.Forms.TextBox txtBxTAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMCCMNC;
        private System.Windows.Forms.Button btnRaiDns;
        private System.Windows.Forms.Button btnTacDns;
        private System.Windows.Forms.ToolStripMenuItem menuZonaRACLAC;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCopyInfo4;
        private System.Windows.Forms.Label lblCopyInfo3;
        private System.Windows.Forms.Label lblCopyInfo2;
        private System.Windows.Forms.Label lblCopyInfo1;
        private System.Windows.Forms.ToolTip toolTipCopy;
    }
}

