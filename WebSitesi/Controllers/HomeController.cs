using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSitesi.Models;

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
