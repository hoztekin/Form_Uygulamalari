using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCDogrulaServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ////////https://tckimlik.nvi.gov.tr/service/kpspublic.asmx?wsdl
            InitializeComponent();
        }      

        private void btnDogrula_Click(object sender, EventArgs e)
        {

            long kimlikNu = long.Parse(txtTcKimlik.Text);   
            int yil = int.Parse(txtBirthDate.Text);
            bool durum;

            try
            {

                using (ServiceReference1.KPSPublicSoapClient service = new ServiceReference1.KPSPublicSoapClient { }) 

                {

                    durum = service.TCKimlikNoDogrula(kimlikNu, txtName.Text, txtLastName.Text, yil);

                    if (durum == true)
                    {
                        MessageBox.Show("Kimlik Numarası doğru", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kimlik Numarası geçerli değil", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
