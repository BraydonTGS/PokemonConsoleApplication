using System;
using Newtonsoft.Json;

namespace PokemonConsoleApp.Pokemons
{
    public class Pokemon : IPokemon
    {

        [JsonProperty("base_experience")]
        public int base_experience { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("held_items")]
        public List<object> held_items { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("is_default")]
        public bool is_default { get; set; }

        [JsonProperty("location_area_encounters")]
        public string location_area_encounters { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("past_types")]
        public List<object> past_types { get; set; }

        [JsonProperty("weight")]
        public int weight { get; set; }
    }
}

