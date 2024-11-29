namespace ComboBoxInceleme
{
    public class urun
    {
        public int id { get; set; }
        public string urunResim { get; set; }
        public string urunAdi { get; set; }
        public string urunKategori { get; set; }
        public int stokAdet { get; set; }
        public string yazar { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return urunAdi;
        }
    }
}
