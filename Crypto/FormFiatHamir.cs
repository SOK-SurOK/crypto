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
            try
            {
                fh.setKey(Convert.ToInt64(textBoxP.Text), Convert.ToInt64(textBoxQ.Text));

                bool f = fh.doo(Convert.ToInt32(textBoxSize.Text));
                if (f)
                    label1.Text = "true";
                else
                    label1.Text = "false";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
          
        }
    }
}
