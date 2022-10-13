using System;
namespace PokemonConsoleApp.Pokemons
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

