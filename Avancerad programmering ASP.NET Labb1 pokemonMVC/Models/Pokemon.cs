using System.Text.Json.Serialization;



namespace Avancerad_programmering_ASP.NET_Labb1_pokemonMVC.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("moves")]
        public List<Movedetails> Moves{ get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites sprites { get; set; } 
    }
}

