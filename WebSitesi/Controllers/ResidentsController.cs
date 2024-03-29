using Microsoft.AspNetCore.Mvc;
using WebSitesi.Models;

namespace WebSitesi.Controllers
{
    public class ResidentsController : Controller
    {
        public IActionResult Index()
        {
            List<Resident> residents = ResidentsRepository.GetResidents();
            return View(residents);
        }
    }
}
