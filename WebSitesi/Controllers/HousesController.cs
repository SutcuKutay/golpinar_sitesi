using Microsoft.AspNetCore.Mvc;
using WebSitesi.Models;


namespace WebSitesi.Controllers
{
    public class HousesController : Controller
    {
        public IActionResult Index()
        {
            List<House> houses = HousesRepository.GetHouses();
            return View(houses);
        }

        public IActionResult Details(int? id)
        {
            House house = new House { HouseId = id.HasValue ? id.Value : 0 };

            return View(house);
        }
    }
}
