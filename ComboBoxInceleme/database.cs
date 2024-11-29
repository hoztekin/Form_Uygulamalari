using System.Collections.Generic;

namespace ComboBoxInceleme
{
    public class database
    {
        public static List<urun> UrunTablo = new List<urun>()
        {
            new urun()
            { 
                id=1, 
                urunAdi = "Bir Ömür Nasıl Yaşanır", 
                stokAdet = 10, 
                urunKategori  = "Roman", 
                aciklama = @"Cesur olun. Kendinizi rahat hissettiğiniz alanın dışında pencereler açın. Farklı dünyalarla ancak böyle tanışırsınız. Ben hep yerimde dursaydım, dünyamı değiştirecek insanları aramasaydım, bugün tanıdığınız ben olmazdım. Bir insanın bittiği an, miskinliğe esir olduğu andır. İnsan, konforundan vazgeçmeyi göze almalıdır. Kendi dünyasını yerinden kendisi oynatmalıdır.", 
                yazar = "İlber Ortaylı", 
                urunResim = @".\Resimler\1.jpg"}, 
            
            new urun(){
                id = 2, urunAdi ="Şeker Portakalı", 
                stokAdet = 10, 
                urunKategori = "Roman", 
                aciklama = @"Ne güzel bir şeker portakalı fidanıymış bu! Hem bak, dikeni de yok. Pek de kişilik sahibiymiş, şeker portakalı olduğu ta uzaktan belli. Ben senin boyunda olsaydım başka şey istemezdim.-", 
                yazar  = "Jose Mauro De Vasconcelos ", 
                urunResim = @".\Resimler\3.jpg"
            }
        };
    }
}
