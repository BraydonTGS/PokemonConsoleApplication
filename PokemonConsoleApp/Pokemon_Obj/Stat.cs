using System;
using Newtonsoft.Json;

namespace PokemonConsoleApp.Pokemon_Obj
{
    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat? stat { get; set; }
    }
}

