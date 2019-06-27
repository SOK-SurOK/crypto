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
    public partial class FormHamir : Form
    {
        Hamir h = new Hamir();
        public FormHamir()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                h.setKey(Convert.ToInt64(textBoxM.Text), Convert.ToInt64(textBoxP.Text),
                    Convert.ToInt32(textBoxK.Text), Convert.ToInt32(textBoxN.Text));
                h.setFunc(Convert.ToInt32(textBoxMax.Text));

                textBox1.Text = "";
                for (int i = 0; i < h.myR.Length; i++)
                {
                    textBox1.Text +=  h.myR[i].ToString()+"\r\n";
                }

                textBox2.Text = "";
                for (int i = 0; i < h.myS.Length; i++)
                {
                    textBox2.Text +=  h.myS[i].ToString()+"\r\n" ;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String[] s = textBox3.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                int[] ii = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    ii[i] = Convert.ToInt32(s[i]);
                }
                textBoxM2.Text = h.getM(ii).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }
    }
}
