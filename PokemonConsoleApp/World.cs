using System;
using System.Linq;
using PokemonConsoleApp.Pokemons;
using static System.Console;
namespace PokemonConsoleApp
{
    public class World
    {
        private string _apiString { get; set; }
        private PokeDex _pokemons { get; set; } = new PokeDex();

        public World()
        {

        }

        public void Run()
        {
            Write("> Please Enter The Name You want to Search For: ");
            var pokeName = ReadLine()?.ToLower().Trim();

            _apiString = $"https://pokeapi.co/api/v2/pokemon/{pokeName}/";

            var name = CatchPokemon.GetName(_apiString);
            var number = CatchPokemon.GetNumber(_apiString);
            var moves = CatchPokemon.GetAbilities(_apiString);
            var type = CatchPokemon.GetType(_apiString);
            var sprites = CatchPokemon.GetSprite(_apiString);

            IPokemon newPokemon = new Pokemon(name, type, number, moves, sprites);

            _pokemons.pokedex.Add(newPokemon);

            foreach (var pokemon in _pokemons.pokedex)
            {
                Console.WriteLine(pokemon.Name);
                Console.WriteLine(pokemon.Number);
                Console.WriteLine(pokemon.Abilities[0]);
                Console.WriteLine(pokemon.Type);
            }

            Console.ReadKey();

        }
    }
}

