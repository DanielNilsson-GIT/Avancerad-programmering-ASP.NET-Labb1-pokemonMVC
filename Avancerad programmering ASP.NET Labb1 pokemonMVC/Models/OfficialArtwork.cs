using System.Text.Json.Serialization;
namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models
{
    public class OfficialArtwork
    {
        [JsonPropertyName("front_shiny")]
        public string frontshiny { get; set; } = string.Empty;
    }
}
