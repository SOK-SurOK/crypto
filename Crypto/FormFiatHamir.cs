using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto
{
    public partial class FormFiatHamir : Form
    {
        public FormFiatHamir()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Fiat_Hamir fh = new Fiat_Hamir();
            fh.setKey(3, 5);
            bool f = fh.doo(10);
            if (f)
                label1.Text = "true";
            else
                label1.Text = "false";
        }
    }
}
