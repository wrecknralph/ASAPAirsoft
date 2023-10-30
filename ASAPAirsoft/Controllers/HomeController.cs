using ASAPAirsoft.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASAPAirsoft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }        

        public ActionResult FirstTab()
        {
            return PartialView("_Guns");
        }

        public ActionResult SecondTab()
        {
            return PartialView("_Locations");
        }
        public ActionResult ThirdTab()
        {
            return PartialView("_Gear");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AirsoftProfile()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}