using FAsgmntV2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FAsgmntV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Style = "authors"; // Set this for author pages
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Dostoyevsky()
        {
            ViewBag.Style = "authors"; // Set this for author pages
            return View();
        }

        public IActionResult Tolstoy()
        {
            ViewBag.Style = "authors"; // Set this for author pages
            return View();
        }

        public IActionResult VictorHugo()
        {
            ViewBag.Style = "authors"; // Set this for author pages
            return View();
        }

        public IActionResult Shakespeare()
        {
            ViewBag.Style = "authors"; // Set this for author pages
            return View();
        }

        public IActionResult SignIn()
        {
            ViewBag.Style = "signin"; // Set this for sign-in page
            return View();
        }


    }
}
