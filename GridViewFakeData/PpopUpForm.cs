using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridViewFakeData
{
    public partial class PpopUpForm : Form
    {
        Musteri musteriData;

        public PpopUpForm(Musteri data)
        {
            InitializeComponent();
            musteriData = data;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PpopUpForm_Load(object sender, EventArgs e)
        {
            txtName.Text = musteriData.name;
            txtLastName.Text = musteriData.lastName;
            txtFullName.Text = musteriData.fullName;
            txtEMail.Text  = musteriData.eMail;
            txtPhoneNumber.Text = musteriData.phoneNumber;
            txtCity.Text = musteriData.city;  
            txtAdres.Text = musteriData.address;

        }
    }
}
