namespace SystemIOForm
{
    public partial class Form1 : Form
    {
        Db Db;
        List<Personel> personellist;

        public Form1()
        {
            InitializeComponent();
            Db = new Db();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

            personellist = Db.personelGetir(150);
            lstPersonel.DataSource = personellist;

        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenPersonel = (Personel)lstPersonel.SelectedItem;

            txtId.Text = secilenPersonel.Id.ToString();
            txtName.Text = secilenPersonel.Name;
            txtLastName.Text = secilenPersonel.LastName;
            txtEMail.Text = secilenPersonel.EMail;
            txtCountry.Text = secilenPersonel.Country;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Db.PersonelKaydet("d:\\deneme", personellist);
        }
    }
}
