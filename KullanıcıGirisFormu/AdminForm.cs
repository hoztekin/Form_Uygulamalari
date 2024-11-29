using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıGirisFormu
{
    public partial class AdminForm : Form
    {
        public AdminForm(Kullanici bulunanKullanici)
        {
            InitializeComponent();
            txtName.Text = bulunanKullanici.Name; 
            txtLastName.Text = bulunanKullanici .LastName;
            txtDescription.Text = bulunanKullanici.Description;
            txtPassword.Text = bulunanKullanici.Password;
            txtUserName.Text = bulunanKullanici.UserName;
            txtUserName.Enabled = false;
            btnGuncelle.Tag = bulunanKullanici.Id;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            
            int KullaniciId = (int)btnGuncelle.Tag;

            int index = SanalDb.Kullanicilar.FindIndex(i => i.Id == KullaniciId);
            SanalDb.Kullanicilar[index].Name = txtName.Text;
            SanalDb.Kullanicilar[index].LastName = txtLastName.Text;
            SanalDb.Kullanicilar[index].Password = txtPassword.Text;
            SanalDb.Kullanicilar[index].Description = txtDescription.Text;

            //MessageBox.Show("Bilgileriniz Güncellendi","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bildirim = new NotifyIcon();
            bildirim.BalloonTipText = "Bilgileriniz Güncellendi";
            bildirim.BalloonTipTitle = "Başarılı";
            bildirim.Visible = true;
            bildirim.Icon = SystemIcons.Information;
            bildirim.ShowBalloonTip(2000);


        }
    }
}
