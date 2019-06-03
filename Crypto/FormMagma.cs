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
    public partial class FormMagma : Form
    {
        public FormMagma()
        {
            InitializeComponent();
        }

        private void ButtonCrypto_Click(object sender, EventArgs e)
        {
            magmaTest(true);
        }

        private void ButtonDecrypto_Click(object sender, EventArgs e)
        {
            magmaTest(false);
        }
        public void magmaTest(bool E)
        {
            /*
            FEDCBA9876543210
            FFEEDDCCBBAA99887766554433221100F0F1F2F3F4F5F6F7F8F9FAFBFCFDFEFF
            4EE901E5C2D8CA3D
            */
            string ref_plain = textBoxIn.Text;
            string ref_key = textBoxKey.Text;

            if (ref_key.Length == 64)
            {
                if (ref_plain.Length == 16)
                {
                    Magma cipher = new Magma();
                    cipher.SetKey(Utils.StringToByteArray(ref_key));
                    if (E)
                    {
                        byte[] result = cipher.Encrypt(Utils.StringToByteArray(ref_plain));
                        textBoxOut.Text = Utils.ByteArrayToString(result);
                    }
                    else
                    {
                        byte[] result = cipher.Dencrypt(Utils.StringToByteArray(ref_plain));
                        textBoxOut.Text = Utils.ByteArrayToString(result);
                    }
                    //CollectionAssert.AreEqual(_ref_cipher, result);//сравнение 2 массивов

                }
                else
                {
                    MessageBox.Show("Введено не 64-битное выражение!");
                }
            }
            else
            {
                MessageBox.Show("Неверный размер ключа!");
            }
        }



    }
}
