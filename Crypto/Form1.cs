﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.Items.AddRange(new string[] { "Магма" });  // добавляем набор элементов
            comboBox1.SelectedIndex = 0;
        }

        private void ButtonCrypto_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    magmaTest();
                    break;
                default:
                    break;
            }
        }

        
        public void magmaTest()
        {
            //byte[] _ref_key = Utils.Unpack("FFEEDDCCBBAA99887766554433221100F0F1F2F3F4F5F6F7F8F9FAFBFCFDFEFF");
            byte[] _ref_key = Utils.StringToByteArray("FFEEDDCCBBAA99887766554433221100F0F1F2F3F4F5F6F7F8F9FAFBFCFDFEFF");
            byte[] _ref_plain = Utils.Unpack("FEDCBA9876543210");
            byte[] _ref_cipher = Utils.Unpack("4EE901E5C2D8CA3D");
            
            Magma cipher = new Magma();
            cipher.SetKey(_ref_key);
            byte[] result = cipher.Encrypt(_ref_plain);
            //CollectionAssert.AreEqual(_ref_cipher, result);//сравнение 2 массивов

            textBoxOut.Text = Utils.ByteArrayToString(result);
        }
    }

    static class Utils
    {
        /// <summary>
        /// Decode hexadecimal string into byte array
        /// </summary>
        /// <param name="hex">String</param>
        /// <returns>Byte[]</returns>
        public static byte[] Unpack(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
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
