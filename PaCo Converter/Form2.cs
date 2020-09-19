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
    public partial class formMCCMNC : Form
    {
        public formMCCMNC()
        {
            InitializeComponent();
            txtBxConfMCC.Text = Properties.Settings.Default.mcc.ToString();
            txtBxConfMNC.Text = Properties.Settings.Default.mnc.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mcc = Int32.Parse(txtBxConfMCC.Text);
            Properties.Settings.Default.mnc = Int32.Parse(txtBxConfMNC.Text);
            Properties.Settings.Default.Save();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validateInteger(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
