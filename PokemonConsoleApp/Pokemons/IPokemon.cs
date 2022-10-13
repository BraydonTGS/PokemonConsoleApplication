using System;
namespace PokemonConsoleApp.Pokemons
{
    public interface IPokemon
    {

        string Name { get; set; }
        string Type { get; set; }
        int Number { get; set; }
        List<string> Abilities { get; set; }
        string Sprite { get; set; }


    }
}

