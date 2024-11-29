using System;
using System.Drawing;
using System.Windows.Forms;

namespace KullanıcıGirisFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            var bulunanKullanici = SanalDb.Kullanicilar.Find(x => x.UserName == userName && x.Password == password);

            if (bulunanKullanici != null) 
            {
                this.Hide();
                AdminForm adminForm = new AdminForm(bulunanKullanici);
                adminForm.Show();           
            }

            //if (userName == "admin" && password == "123")
            //{
            //    AdminForm adminForm = new AdminForm(userName);
            //    adminForm.Show();   
            //}
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.AliceBlue;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {            
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }
    }
}
