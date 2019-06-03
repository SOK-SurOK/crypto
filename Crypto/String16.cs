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
    public partial class String16 : Form
    {
        public String16()
        {
            InitializeComponent();
        }

        private void ButtonText_Click(object sender, EventArgs e)
        {
            string str = textBoxText.Text;
            textBoxText.Text = Utils.StringToHexString(str);
        }

        private void ButtonTextS_Click(object sender, EventArgs e)
        {
            string str = textBoxText.Text;
            if (str.Length % 2 == 0)
            {
                textBoxText.Text = Utils.HexStringToString(str);
            }
            else
            {
                MessageBox.Show("Неверный размер шестнадцатиричной строки!");
            }
        }

        private void TextBoxText_TextChanged(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(textBoxText.Text.Length);
        }
    }
}
