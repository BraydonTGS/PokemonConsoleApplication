using System;
namespace PokemonConsoleApp.Pokemons
{
    public class PokeDex
    {
        public List<Pokemon> pokedex { get; set; }

        public PokeDex()
        {
            pokedex = new List<Pokemon>();
        }
    }
}

