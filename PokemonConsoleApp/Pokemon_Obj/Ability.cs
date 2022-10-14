using System;
using Newtonsoft.Json;

namespace PokemonConsoleApp.Pokemon_Obj
{
    public class Ability
    {

        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }

    }
}

