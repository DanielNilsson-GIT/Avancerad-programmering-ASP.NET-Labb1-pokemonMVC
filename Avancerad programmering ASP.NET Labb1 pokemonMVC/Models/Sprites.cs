using System.Text.Json.Serialization;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models
{
    public class Sprites
    {
        [JsonPropertyName("other")]
        public Other other { get; set; } = new(); //new för att inte få null
        
    }
}
