using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GridViewFakeData
{
    public partial class Form1 : Form
    {
        List<Musteri> musteri;
        public Form1()
        {
            //behaivor selection mode ""full row select"" seçildiğinde o hücreye işlem yapılabilir
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string name = FakeData.NameData.GetFirstName();
            //string lastName = FakeData.NameData.GetSurname();

            database db = new database();
            musteri = db.musteriListele();


            dgwMusteriList.DataSource = musteri;


            // 1. Data bize lazım ama ekran üzerinde göstermek istemiyoruz, bu gibi durumlarda columns koleksiyonu içinde ilgili kolonun id değeri veya tip prop adı verilerek Visible prop false edilmesi yeterlidir. 

            //dgwMusteriListe.Columns[0].Visible = false;
            dgwMusteriList.Columns["id"].Visible = true;

            //// Data Grid View içerisinde bulunan kolonların isimlerini değiştirmek... 

            dgwMusteriList.Columns[0].HeaderText = "Müşteri ID";
            dgwMusteriList.Columns[1].HeaderText = "Müşteri İsim";
            dgwMusteriList.Columns[2].Width = 200;


            // 2. Data bize lazım değil hiç bir şekilde ekranda görünmesini veya kullanmak istemiyoruz. 

            //var dgwListe = from x in musteri
            //               select new
            //               {
            //                   Ad = x.name,
            //                   Soyad = x.lastName,
            //                   AdSoyad = x.fullName
            //               };
            //dgwMusteriList.DataSource = dgwListe.ToList();

        }

        private void dgwMusteriList_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            //var t = dgwMusteriList.SelectedRows[0];
            int musteriId = (int) dgwMusteriList[0,dgwMusteriList.CurrentCell.RowIndex].Value;
            Musteri bulunanMusteri = musteri.Find(i => i.id == musteriId);
            PpopUpForm form = new PpopUpForm(bulunanMusteri);
            form.Show();


        }
    }
}
