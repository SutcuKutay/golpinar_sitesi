using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSitesi.Models;

/*Test ama�l� kodlar. Projenin son halinde bir i�levleri yok.*/

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
