namespace SystemIOForm
{
    public class Db
    {
        public Db()
        {

        }
        public List<Personel> personelGetir(int adet)
        {
            List<Personel> personelList = new List<Personel>();

            int id = 0;

            for (int i = 0; i <= adet; i++)
            {
                Personel personel = new Personel();
                personel.Id = id++;
                personel.Name = FakeData.NameData.GetFirstName();
                personel.LastName = FakeData.NameData.GetSurname();
                personel.EMail = FakeData.NetworkData.GetEmail();
                personel.Country = FakeData.PlaceData.GetCountry();
                personelList.Add(personel);
            }
            return personelList;
        }

        public void PersonelKaydet(string path, List<Personel> personels)
        {
            DirectoryInfo countryInfo = null;
            for (int i = 0; i < personels.Count; i++)
            {
                if (Directory.Exists(path + "\\" + personels[i].Country))
                {
                    countryInfo = new DirectoryInfo(path + "\\" + personels[i].Country);
                }
                else
                {
                    Directory.CreateDirectory(path + "\\" + personels[i].Country);
                }
                FileStream fs = File.Create(countryInfo.FullName + "\\" + personels[i].Name + "." + personels[i].LastName + ".txt");
                byte[] personelInfo = new System.Text.UTF8Encoding(true).GetBytes(personels[i].personelGetir());
                fs.Write(personelInfo, 0, personelInfo.Length);
                fs.Close();

            }
        }


    }
}
