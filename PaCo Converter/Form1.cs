using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaCo_Converter
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void validateInteger(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " " + Application.ProductVersion;

            lblCopyInfo3.Text = "mnc" + Properties.Settings.Default.mnc.ToString("D3") + ".mcc" + Properties.Settings.Default.mcc.ToString("D3") + lblCopyInfo3.Text;
            lblCopyInfo4.Text = "epc.mnc" + Properties.Settings.Default.mnc.ToString("D3") + ".mcc" + Properties.Settings.Default.mcc.ToString("D3") + lblCopyInfo4.Text;
        }

        private void MenuMCCMNC_Click(object sender, EventArgs e)
        {
            formMCCMNC frmMccMnc = new formMCCMNC();
            frmMccMnc.ShowDialog();
        }

        private void MenuZonaRACLAC_Click(object sender, EventArgs e)
        {
            formZonaRacLac frmRacLac = new formZonaRacLac();
            frmRacLac.ShowDialog();
        }

        private void BtnHexaDec_Click(object sender, EventArgs e)
        {
            if (txtBxHexa.Text != "" && txtBxDec.Text != "")
            {
                txtBxHexa.Text = txtBxDec.Text = "";
            }
            else if (txtBxHexa.Text != "")
            {
                txtBxDec.Text = int.Parse(txtBxHexa.Text, System.Globalization.NumberStyles.HexNumber).ToString();
            }
            else if (txtBxDec.Text != "")
            {
                txtBxHexa.Text = int.Parse(txtBxDec.Text).ToString("X");
            }
            else
            {
                MessageBox.Show("Preencha um dos campos para realizar a conversão");
            }
        }

        private void BtnRaiDns_Click(object sender, EventArgs e)
        {
            if (txtBxRAC.Text != "" && txtBxLAC.Text != "" && txtBxRAIDNS.Text != "")
            {
                txtBxRAC.Text = txtBxLAC.Text = txtBxRAIDNS.Text = "";
            }
            else if (txtBxRAC.Text != "" && txtBxLAC.Text != "")
            {
                string racHost = "rac" + int.Parse(txtBxRAC.Text).ToString("X4");
                string lacHost = "lac" + int.Parse(txtBxLAC.Text).ToString("X4");
                string domain = "mnc" + Properties.Settings.Default.mnc.ToString("D3") + ".mcc" + Properties.Settings.Default.mcc.ToString("D3");

                switch(Properties.Settings.Default.laczone)
                {
                    case 0:
                        domain += ".gprs";
                        break;
                    case 1:
                        domain = "rac.epc." + domain + ".3gppnetwork.org";
                        break;
                }
                txtBxRAIDNS.Text = racHost + "." + lacHost + "." + domain;
            }
            else if(txtBxRAIDNS.Text != "")
            {
                string raiDNS = txtBxRAIDNS.Text;
                string[] raiHost = raiDNS.Split('.');
                string rac = raiHost[0].Substring(4).ToString();
                string lac = raiHost[1].Substring(4).ToString();
                txtBxRAC.Text = int.Parse(rac, System.Globalization.NumberStyles.HexNumber).ToString();
                txtBxLAC.Text = int.Parse(lac, System.Globalization.NumberStyles.HexNumber).ToString();
            }
            else
            {
                MessageBox.Show("Preencha um dos campos para realizar a conversão");
            }
        }

        private void BtnTacDns_Click(object sender, EventArgs e)
        {
            if(txtBxTAC.Text != "" && txtBxTACDNS.Text != "")
            {
                txtBxTAC.Text = txtBxTACDNS.Text = "";
            }
            else if(txtBxTAC.Text != "")
            {
                string tacHex = int.Parse(txtBxTAC.Text).ToString("X4");
                string tacLb = tacHex.Substring(2, 2);
                string tacHb = tacHex.Substring(0, 2);
                string tacHost = "tac-lb" + tacLb + ".tac-hb" + tacHb;
                string domain = "mnc" + Properties.Settings.Default.mnc.ToString("D3") + ".mcc" + Properties.Settings.Default.mcc.ToString("D3");
                txtBxTACDNS.Text = tacHost + ".tac.epc." + domain + ".3gppnetwork.org";
            }
            else if(txtBxTACDNS.Text != "")
            {
                string tacDNS = txtBxTACDNS.Text;
                string[] tacHost = tacDNS.Split('.');
                string tacLb = tacHost[0].Substring(6, 2);
                string tacHb = tacHost[1].Substring(6, 2);
                string tacHex = tacHb + tacLb;
                txtBxTAC.Text = int.Parse(tacHex, System.Globalization.NumberStyles.HexNumber).ToString();
            }
            else
            {
                MessageBox.Show("Preencha um dos campos para realizar a conversão");
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAbout frmAbout = new formAbout();
            frmAbout.ShowDialog();
        }

        private void LblHexa_Click(object sender, EventArgs e)
        {
            if(txtBxHexa.Text != "")
            {
                Clipboard.SetText(txtBxHexa.Text);
            }
        }

        private void LblDec_Click(object sender, EventArgs e)
        {
            if (txtBxDec.Text != "")
            {
                Clipboard.SetText(txtBxDec.Text);
            }
        }

        private void LblRAC_Click(object sender, EventArgs e)
        {
            if (txtBxRAC.Text != "")
            {
                Clipboard.SetText(txtBxRAC.Text);
            }
        }

        private void LblLAC_Click(object sender, EventArgs e)
        {
            if (txtBxLAC.Text != "")
            {
                Clipboard.SetText(txtBxLAC.Text);
            }
        }

        private void LblRAIDNS_Click(object sender, EventArgs e)
        {
            if (txtBxRAIDNS.Text != "")
            {
                Clipboard.SetText(txtBxRAIDNS.Text);
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            if (txtBxTAC.Text != "")
            {
                Clipboard.SetText(txtBxTAC.Text);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            if (txtBxTACDNS.Text != "")
            {
                Clipboard.SetText(txtBxTACDNS.Text);
            }
        }
    }
}
