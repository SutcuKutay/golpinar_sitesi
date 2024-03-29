namespace WebSitesi.Models
{
    public class HousesRepository
    {
        private static List<House> _houses = new List<House>()
        {
            new House { HouseId = 1, Description = "Bizim ev", No = "29" },
            new House { HouseId = 2, Description = "", No = "32" },
            new House { HouseId = 3, Description = "", No = "12" },
            new House { HouseId = 4, Description = "", No = "33" },
            new House { HouseId = 5, Description = "", No = "22" },
            new House { HouseId = 6, Description = "", No = "14" }
        };

        public static List<House> GetHouses()
        {
            return _houses;
        }
    }
}
