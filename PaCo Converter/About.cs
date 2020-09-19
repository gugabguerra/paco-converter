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
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            lblAboutAppName.Text = Application.ProductName;
            lblAboutAppVersion.Text = "\rversão " + Application.ProductVersion + "\rcopyright @gugabguerra";
        }
    }
}
