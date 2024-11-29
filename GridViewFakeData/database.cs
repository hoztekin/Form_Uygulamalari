using System.Collections.Generic;

namespace GridViewFakeData
{
    public class database
    {
        public List<Musteri>  musteriler = new List<Musteri>();

        public database() 
        {

        }

        public List<Musteri> musteriListele() 
        {
            for (int i = 1; i < 1001; i++)
            {
                Musteri temp = new Musteri();
                temp.id = 1000+i;
                temp.name = FakeData.NameData.GetFirstName();
                temp.lastName = FakeData.NameData.GetSurname(); 
                temp.fullName = $"{temp.name} {temp.lastName}";
                temp.eMail = temp.fullName + FakeData.NetworkData.GetEmail(temp.name, temp.lastName);
                temp.phoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                temp.city = FakeData.PlaceData.GetCity();
                temp.district = FakeData.PlaceData.GetCountry();
                temp.address = FakeData.PlaceData.GetAddress(); 
                musteriler.Add(temp);   
            }
            return musteriler;
        }
    }
}
