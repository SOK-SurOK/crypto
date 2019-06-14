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
            
            comboBoxVibor.Items.AddRange(new string[] {"Перевод", "Магма", "RSA", "Хэш-Магма" });
            comboBoxVibor.SelectedIndex = 0;
        }
  
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            switch (comboBoxVibor.SelectedIndex)
            {
                case 0:
                    String16 f0 = new String16();
                    f0.Show();
                    break;
                case 1:
                    FormMagma f1 = new FormMagma();
                    f1.Show();
                    break;
                case 2:
                    FormRSA f2 = new FormRSA();
                    f2.Show();
                    break;
                case 3:
                    XehMagmaForm f3 = new XehMagmaForm();
                    f3.Show();
                    break;
                default:
                    break;
            }
        }


    }

   
}
