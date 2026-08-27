using Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<Pokemon?> GetPokemon(string name)
        {
            var url = $"https://pokeapi.co/api/v2/pokemon/{name.ToLower()}";

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<Pokemon>(json);

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public async Task<List<Pokemon>> GetAllPokemons()
        {
            var url = "https://pokeapi.co/api/v2/pokemon";

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<PokemonApiResponse>(json);
                return data.Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        internal class PokemonApiResponse()
        {
            [System.Text.Json.Serialization.JsonPropertyName("results")]
            public List<Pokemon>? Result { get; set; }

        }

    }
}
