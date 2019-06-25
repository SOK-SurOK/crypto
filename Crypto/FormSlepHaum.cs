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
    public partial class FormSlepHaum : Form
    {
        SlepHaum sh = new SlepHaum();
        public FormSlepHaum()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                sh.SetKeys(Convert.ToInt64(textBoxP.Text), Convert.ToInt64(textBoxQ.Text), Convert.ToInt32(textBoxMax.Text));
                labelK.Text = sh.myK.ToString();
                labelN.Text = sh.myN.ToString();
                labelD.Text = sh.myD.ToString();
                labelE.Text = sh.myE.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            textBox2.Text = sh.GetY(Convert.ToInt64(textBox1.Text)).ToString();
        }

        private void ButtonEn_Click(object sender, EventArgs e)
        {
            try
            {
                long z = sh.GetZ(Convert.ToInt64(textBox2.Text));
                textBox2.Text = sh.Encrypt(z).ToString();
                labelS.Text = sh.GetS(Convert.ToInt64(textBox1.Text)).ToString();
            }
            catch (System.OverflowException ex)
            {
                MessageBox.Show($"Исключение переполнения: {ex.Message}");
            }
        }
    }
}
