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
    public partial class FormRSA : Form
    {
        RSA rsa = new RSA();
        public FormRSA()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                rsa.SetKeys(Convert.ToInt64(textBoxP.Text), Convert.ToInt64(textBoxQ.Text));
                textBoxE.Text = rsa.getE.ToString();
                textBoxN.Text = rsa.getN.ToString();
                textBoxD.Text = rsa.getD.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Похоже числа не простые");
            }
        }

        private void ButtonEn_Click(object sender, EventArgs e)
        {
            long s = rsa.Encrypt(Convert.ToInt64(textBox.Text));
            textBox.Text = s.ToString();
        }

        private void ButtonDe_Click(object sender, EventArgs e)
        {
            long s = rsa.Decrypt(Convert.ToInt64(textBox.Text));
            textBox.Text = s.ToString();
        }
    }
}
