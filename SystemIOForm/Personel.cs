namespace SystemIOForm
{
    public class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
        public string personelGetir()
        {
            return String.Format("İsim:{0} Soyisim :{1} EMail Adres :{2} Ülke:{3}", Name, LastName,EMail,Country);
        }
    }
}
