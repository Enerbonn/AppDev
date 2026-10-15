using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Enerbon()
        {
            EnerbonModel siEnerbon = new EnerbonModel(
                19,
                "Irvin John J. Parulan",
                "IV OF SPADES ♠",
                "walA",
                "Konoha Village, Biringan City",
                new string[] { "kagebunshin tektik", "BANKAI!", "Transform (Ben 10)" },
                "https://irvinparulan.com/dipatapos"
            );
            return View(siEnerbon);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

