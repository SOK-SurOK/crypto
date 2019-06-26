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
            
            comboBoxVibor.Items.AddRange(new string[] {"Перевод", "Магма", "RSA", "Хэш-Магма", "Фиат-Шамир", "Слепой Чаум", "Онго-Шнора-Шамира", "Шамир"});
            comboBoxVibor.SelectedIndex = 0;
        }
  
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            switch (comboBoxVibor.SelectedIndex)
            {
                case 0:
                    FormString16 f0 = new FormString16();
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
                    FormXehMagma f3 = new FormXehMagma();
                    f3.Show();
                    break;
                case 4:
                    FormFiatHamir f4 = new FormFiatHamir();
                    f4.Show();
                    break;
                case 5:
                    FormSlepHaum f5 = new FormSlepHaum();
                    f5.Show();
                    break;
                case 6:
                    FormOngoHnorHamir f6 = new FormOngoHnorHamir();
                    f6.Show();
                    break;
                case 7:
                    FormHamir f7 = new FormHamir();
                    f7.Show();
                    break;
                default:
                    break;
            }
        }


    }

   
}
