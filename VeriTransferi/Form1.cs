using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTransferi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMsg.Text = "Metin Giriniz";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string mesajDegeri = txtMsg.Text;

            Form2 form2 = new Form2 (mesajDegeri);
            form2.Show();
        }

        private void txtMsg_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.Text = string.Empty;
        }
    }
}
