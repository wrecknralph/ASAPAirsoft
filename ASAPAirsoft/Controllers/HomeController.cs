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
<<<<<<< Updated upstream
        }

        public ActionResult FirstTab()
        {
            return PartialView("_FirstTab");
        }

        public ActionResult SecondTab()
        {
            return PartialView("_SecondTab");
        }
=======
        }                
>>>>>>> Stashed changes

        public IActionResult Index()
        {
            return View();
<<<<<<< Updated upstream
        }

        public IActionResult Privacy()
        {
            return View();
        }
=======
        }        
>>>>>>> Stashed changes

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}