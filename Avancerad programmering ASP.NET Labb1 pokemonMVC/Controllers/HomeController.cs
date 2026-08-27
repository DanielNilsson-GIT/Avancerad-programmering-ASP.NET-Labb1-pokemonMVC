using Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models;
using Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPokemonService _pokemonService;
        
        public HomeController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }
        public async Task<IActionResult> Index()
        {
            var pokemon = await _pokemonService.GetAllPokemons();
            return View(pokemon);
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
