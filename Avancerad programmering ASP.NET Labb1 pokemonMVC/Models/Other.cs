using System.Text.Json.Serialization;

namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models
{
    public class Other
    {
        [JsonPropertyName("official-artwork")]
        public OfficialArtwork officialartwork { get; set; } = new();
    }
}
