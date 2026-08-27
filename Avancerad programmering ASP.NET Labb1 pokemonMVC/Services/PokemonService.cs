using Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models;
using System.Text.Json;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient client)
        {
            _httpClient = client;
        }

        public Task<List<Pokemon>> GetPokemon(string name)
        {
            var baseUrl = name;
        }

        public async Task<List<Pokemon>> GetAllPokemons()
        {
            var url = "här anropar jag alla pokemons namn och ska sedan visa dom i en lista";

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<PokemonApiResponse>(json);
                return data.Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        internal class PokemonApiResponse()
        {
            [System.Text.Json.Serialization.JsonPropertyName("??")]
            public List<Pokemon>? Result { get; set; }
        }

    }
}
