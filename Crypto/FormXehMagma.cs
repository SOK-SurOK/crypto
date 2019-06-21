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
    public partial class FormXehMagma : Form
    {
        public FormXehMagma()
        {
            InitializeComponent();
        }

        private void ButtonEn_Click(object sender, EventArgs e)
        {
            XehMagma xm = new XehMagma();
            try
            {
                string s;

                string k="";
                //Random rnd = new Random();
                //while (k.Length != 64)
                //{
                //    k += rnd.Next(0, 10);
                //}
                k = textBox.Text.Substring(0, 16);
                k = k + k + k + k;
                s = xm.Encrypt(k, textBox.Text);
                //textBox.Text = s;
                textBoxKey.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }

        private void ButtonR_Click(object sender, EventArgs e)
        {
            string t = "";//, k="";
            Random rnd = new Random();
            //while(k.Length != 64)
            //{
            //    k += rnd.Next(0, 10);
            //}
            var l = rnd.Next(64);
            while(t.Length != l)
            {
                t += rnd.Next(0, 10);
            }
            textBox.Text = t;
            //textBoxKey.Text = k;
        }
    }
}
