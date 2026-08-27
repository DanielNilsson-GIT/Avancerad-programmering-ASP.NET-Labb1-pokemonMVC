using Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Services
{
    public interface IPokemonService
    {
       public Task<List<Pokemon>> GetPokemon(string name);

       public Task<List<Pokemon>> GetAllPokemons(string request);
        
    }
}
