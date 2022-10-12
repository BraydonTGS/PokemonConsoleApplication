using System;
namespace PokemonConsoleApp.Pokemon
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

