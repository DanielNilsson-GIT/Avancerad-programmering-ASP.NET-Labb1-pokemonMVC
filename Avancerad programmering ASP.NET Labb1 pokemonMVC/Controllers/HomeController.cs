using Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search()
        {
            return View(Search);
        }
    }
}
