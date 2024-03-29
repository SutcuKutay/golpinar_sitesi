using Microsoft.AspNetCore.Mvc;

namespace WebSitesi.Controllers
{
    public class PresidentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
