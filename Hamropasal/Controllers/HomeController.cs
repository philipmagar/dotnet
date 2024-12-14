using System.Diagnostics;
using Hamropasal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hamropasal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Contact()
        {
            Contact ct = new Contact(){
               City="Ktm",
               Street ="Bafal",
               PostalCode="104"
            };

            ViewData["contact"] = ct;//sending data to view

            return View();  
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
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
    }
}
