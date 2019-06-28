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
    public partial class FormOngoHnorHamir : Form
    {
        OngoHnorHamir ohh = new OngoHnorHamir();
        public FormOngoHnorHamir()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ohh.SetKeys(Convert.ToInt64(textBoxP.Text), Convert.ToInt64(textBoxQ.Text), Convert.ToInt32(textBoxMax.Text));
                textBoxX.Text = ohh.myK.ToString();
                textBoxY.Text = ohh.myN.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ohh.setS(Convert.ToInt64(textBoxX.Text), Convert.ToInt64(textBoxY.Text));
                textBoxX2.Text = ohh.isTrue((Convert.ToInt64(textBoxX.Text))).ToString();
                textBoxY2.Text = ohh.getY((Convert.ToInt64(textBoxX.Text))).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }
    }
}
