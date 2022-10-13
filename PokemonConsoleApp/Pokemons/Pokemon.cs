using System;
using Newtonsoft.Json;

namespace PokemonConsoleApp.Pokemons
{
    public class Pokemon
    {

        [JsonProperty("abilities")]
        public List<string>? Abilities { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("held_items")]
        public List<object>? HeldItems { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("location_area_encounters")]
        public string? LocationAreaEncounters { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("sprites")]
        public string? Sprites { get; set; }

        [JsonProperty("types")]
        public List<string>? Types { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }
}

