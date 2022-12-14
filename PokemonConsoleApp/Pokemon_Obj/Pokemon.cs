using System;
using Newtonsoft.Json;

namespace PokemonConsoleApp.Pokemon_Obj
{
    public class Pokemon : IPokemon
    {
        public List<Ability>? abilities { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public List<object>? held_items { get; set; }
        public int id { get; set; }
        public string? location_area_encounters { get; set; }
        public List<Move>? moves { get; set; }
        public string? name { get; set; }
        public int order { get; set; }
        public List<object>? past_types { get; set; }
        public Sprites? sprites { get; set; }
        public List<Stat>? stats { get; set; }
        public List<Type>? types { get; set; }
        public int weight { get; set; }
    }
}

