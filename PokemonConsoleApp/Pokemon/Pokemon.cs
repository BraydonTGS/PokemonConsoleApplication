using System;

namespace PokemonConsoleApp.Pokemon
{
    public class Pokemon : IPokemon
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public List<string> Abilities { get; set; }
        public string Sprite { get; set; }

        public Pokemon(string name, string type, int number, List<string> abilities, string sprite)
        {
            Name = name;
            Type = type;
            Number = number;
            Abilities = abilities;
            Sprite = sprite;
        }
    }
}

