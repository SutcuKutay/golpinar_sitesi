/*Veritabanı yoksa test amaçlı kullanılan veriler*/

namespace WebSitesi.Models
{
    public class ResidentsRepository
    {
        private static List<Resident> _residents = new List<Resident>()
        {
            new Resident { ResidentId = 1, Name = "Kutay Sütçü", HouseNumber = "29", PhoneNumber = "333333333" },
            new Resident { ResidentId = 2, Name = "Ecre Miray", HouseNumber = "33", PhoneNumber = "555555555"},
            new Resident { ResidentId = 3, Name = "Emirali Yıldız", HouseNumber = "34", PhoneNumber = "333333333" },
            new Resident { ResidentId = 4, Name = "Emirhan Tuncay", HouseNumber = "12", PhoneNumber = "555555555"},
            new Resident { ResidentId = 5, Name = "Fatih Terim", HouseNumber = "30", PhoneNumber = "333333333" },
            new Resident { ResidentId = 6, Name = "Susen Uzun", HouseNumber = "13", PhoneNumber = "555555555"},
            new Resident { ResidentId = 7, Name = "Nursima Fatıma", HouseNumber = "17", PhoneNumber = "333333333" },
            new Resident { ResidentId = 8, Name = "Ronaldo Cristiano", HouseNumber = "26", PhoneNumber = "555555555"}
        };

        public static List<Resident> GetResidents()
        {
            return _residents;
        }
    }
}
