using System;
using PokemonConsoleApp.Pokemon_Obj;


namespace PokemonConsoleApp.Pokedex
{
    public class PokeDex
    {
        public List<IPokemon> pokedex { get; set; }

        public PokeDex()
        {
            pokedex = new List<IPokemon>();
        }
    }
}

