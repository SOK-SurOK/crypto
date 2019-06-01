using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBoxVibor.Items.AddRange(new string[] { "Магма" });  // добавляем набор элементов
            comboBoxVibor.SelectedIndex = 0;
        }

        private void ButtonCrypto_Click(object sender, EventArgs e)
        {
            switch (comboBoxVibor.SelectedIndex)
            {
                case 0:
                    magmaTest(true);
                    break;
                default:
                    break;
            }
        }

        
       

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDecrypto_Click(object sender, EventArgs e)
        {
            switch (comboBoxVibor.SelectedIndex)
            {
                case 0:
                    magmaTest(false);
                    break;
                default:
                    break;
            }
        }




        public void magmaTest(bool E)
        {
            //byte[] _ref_key = Utils.Unpack("FFEEDDCCBBAA99887766554433221100F0F1F2F3F4F5F6F7F8F9FAFBFCFDFEFF");
            //byte[] _ref_plain = Utils.Unpack("FEDCBA9876543210");
            //       byte[] _ref_cipher = Utils.Unpack("8fc6feb891514c37");
            //byte[] _ref_cipher = Utils.Unpack("4EE901E5C2D8CA3D");


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

        private void ButtonText_Click(object sender, EventArgs e)
        {
            string str = textBoxText.Text;
            textBoxText.Text = Utils.StringToHexString(str);
        }

        private void ButtonTextS_Click(object sender, EventArgs e)
        {
            string str = textBoxText.Text;
            textBoxText.Text = Utils.HexStringToString(str);
        }
    }






    static class Utils
    {

        // Декодировать шестнадцатеричную строку в массив байтов

        //public static byte[] Unpack(string hex)
        //{
        //    return Enumerable.Range(0, hex.Length)
        //                     .Where(x => x % 2 == 0)
        //                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
        //                     .ToArray();
        //}
        public static string StringToHexString(string str)
        {
            byte[] ba = Encoding.Default.GetBytes(str);
            var hexString = BitConverter.ToString(ba);
            return hexString.Replace("-", "");
        }

        public static string HexStringToString(string str)
        {
            byte[] bb = Enumerable.Range(0, str.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(str.Substring(x, 2), 16))
                             .ToArray();

            return System.Text.Encoding.UTF8.GetString(bb);
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public static byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
