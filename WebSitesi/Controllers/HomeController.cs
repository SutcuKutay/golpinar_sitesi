using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSitesi.Models;

/*Test amaçlý kodlar. Projenin son halinde bir iþlevleri yok.*/

namespace WebSitesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
