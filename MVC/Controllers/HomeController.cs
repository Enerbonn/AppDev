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
            
            ProfileModel model1 = new ProfileModel(18, "Irvin", "I love music.");
            return View(model1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
