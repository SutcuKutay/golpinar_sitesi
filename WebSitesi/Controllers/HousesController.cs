using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSitesi.Models;

namespace WebSitesi.Controllers
{
    public class HousesController : Controller
    {
        private readonly DataBaseFirstDbContext dbContext;

        public HousesController(DataBaseFirstDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //var evler = await dbContext.Evlers.ToListAsync();

            //return View(evler);

            var evler = from ev in dbContext.Evlers
                        join site_sakini in dbContext.SiteSakinleris on ev.Sahibi equals site_sakini.Id
                        join kiraci in dbContext.Kiracilars on ev.Kiracı equals kiraci.Id into kiracilar
                        from kiraci in kiracilar.DefaultIfEmpty() 
                        select new EvSahipKiraciModel
                        {
                            Ev_Numarasi = ev.Numara.ToString(),
                            Ev_Sahibi = site_sakini.AdSoyad,
                            Kiraci = kiraci.AdSoyad
                        };

            return View(evler);
        }

        //private readonly AppDbContext dbContext;

        //public HousesController(AppDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}

        //public IActionResult Index()
        //{
        //    /*List<House> houses = HousesRepository.GetHouses();
        //    return View(houses);*/
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Add()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(EvEkleViewModel viewModel)
        //{
        //    var house = new House
        //    {
        //        Number = viewModel.numara
        //    };
        //    //await dbContext.Houses.AddAsync()
        //    return View();
        //}

        //public IActionResult Details(int? id)
        //{
        //    /*House house = new House { HouseId = id.HasValue ? id.Value : 0 };

        //    return View(house);*/
        //    return View(id);
        //}
    }
}
