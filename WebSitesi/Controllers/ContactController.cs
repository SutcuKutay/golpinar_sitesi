using Microsoft.AspNetCore.Mvc;

namespace WebSitesi.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
