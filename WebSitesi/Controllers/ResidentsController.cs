using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSitesi.Data;
using WebSitesi.Models;
using WebSitesi.Models.Ekleme;
using WebSitesi.Models.Entities;

namespace WebSitesi.Controllers
{
    public class ResidentsController : Controller
    {
        private readonly DataBaseFirstDbContext dbContext;

        public ResidentsController(DataBaseFirstDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var site_sakinleri = await dbContext.SiteSakinleris.ToListAsync();
            return View(site_sakinleri);
        }

        //private readonly AppDbContext dbContext;

        //public ResidentsController(AppDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}

        //public IActionResult Index()
        //{
        //    /*List<Resident> residents = ResidentsRepository.GetResidents();
        //    return View(residents);*/
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Add()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(ResidentEkleViewModel viewModel)
        //{
        //    var resident = new Resident
        //    {
        //        Name = viewModel.Name,
        //        Phone = viewModel.Phone
        //    };

        //    await dbContext.Residents.AddAsync(resident);
        //    await dbContext.SaveChangesAsync();
        //    return View();
        //}
    }
}
