using System.Text.Json.Serialization;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models
{
    public class Movedetails
    {
        [JsonPropertyName("move")]
        public Moves move { get; set; }
    }
}
