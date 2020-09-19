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
    public partial class formZonaRacLac : Form
    {
        public formZonaRacLac()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(radioGprs.Checked == true)
            {
                Properties.Settings.Default.laczone = 0;
            }
            else if(radio3gpp.Checked == true)
            {
                Properties.Settings.Default.laczone = 1;
            }
            Properties.Settings.Default.Save();
            Close();
        }

        private void BntCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormZonaRacLac_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.laczone)
            {
                case 0:
                    radioGprs.Checked = true;
                    radio3gpp.Checked = false;
                    break;
                case 1:
                    radioGprs.Checked = false;
                    radio3gpp.Checked = true;
                    break;
            }
        }
    }
}
