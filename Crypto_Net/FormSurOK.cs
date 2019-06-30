using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Net
{
    public partial class FormSurOK : Form
    {
        Client1 c1;
        ServerProverka sp;
        ServerData sd;
        public FormSurOK()
        {
            InitializeComponent();
            c1 = new Client1();
            sp = new ServerProverka();
            sd = new ServerData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                sp.ServerDo();
                sd.ServerDo();
                label3.Text = "Сервера запущены";
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
                //long pas = Convert.ToInt64(textBox1.Text);
                long otv;
                otv = c1.ClientDo();
                textBox2.Text = otv.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            sp.ServerStop();
            sd.ServerStop();
            label3.Text = "Сервера остановлены";
        }
    }
}
