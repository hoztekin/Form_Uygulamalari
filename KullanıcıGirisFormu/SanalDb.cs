using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirisFormu
{
    public class SanalDb
    {
        public static List<Kullanici> Kullanicilar = new List<Kullanici>();

        static SanalDb()
        {
            Kullanicilar.Add(new Kullanici()
            {
                Id = 1,
                Name = "Halil",
                LastName = "Öztekin",
                UserName = "hoztekin",
                Password = "1234",
                Description = "Admin"


            });

            Kullanicilar.Add(new Kullanici()
            {
                Id = 2,
                Name = "Hakan",
                LastName = "Sayılır",
                UserName = "hsayilir",
                Password = "1234",
                Description = "Admin"
            });

        }
    }
}
