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
                textBoxE.Text = rsa.myE.ToString();
                textBoxN.Text = rsa.myN.ToString();
                textBoxD.Text = rsa.myD.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }

        private void ButtonEn_Click(object sender, EventArgs e)
        {
            try
            {
                long s = rsa.Encrypt(Convert.ToInt64(textBox.Text), Convert.ToInt64(textBoxE.Text), Convert.ToInt64(textBoxN.Text));
                textBox.Text = s.ToString();
            }
            catch (System.OverflowException ex)
            {
                MessageBox.Show($"Исключение переполнения: {ex.Message}");
            }
        }

        private void ButtonDe_Click(object sender, EventArgs e)
        {
            try
            {
                long s = rsa.Decrypt(Convert.ToInt64(textBox.Text), Convert.ToInt64(textBoxD.Text), Convert.ToInt64(textBoxN.Text));
                textBox.Text = s.ToString();
            }
            catch (System.OverflowException ex)
            {
                MessageBox.Show($"Исключение переполнения: {ex.Message}");
            }
        }
    }
}
