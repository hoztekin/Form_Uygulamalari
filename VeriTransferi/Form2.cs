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
    public partial class Form2 : Form
    {
        public Form2(string mesaj)
        {
            InitializeComponent();
            label1.Text = mesaj;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
