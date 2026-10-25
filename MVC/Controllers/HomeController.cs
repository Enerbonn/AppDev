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
        
        public IActionResult Profile()
        {
          Profile profile = new Profile("Polytechnic University of the Philippines","Jamila Dela Pena", "09760353970", "Manila, Philippines", new List<string>
        {
            "HTML",
            "CSS",
            "GitHub",
            "Git",
            "C#",
            "Java"
        });
            return View(profile);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
