using System;
using PokemonConsoleApp.Pokemon;
using static System.Console;
namespace PokemonConsoleApp
{
    public class World
    {
        private string _apiString { get; set; }
        public World()
        {
        }

        public void Run()
        {
            Write("> Please Enter The Name You want to Search For: ");
            var pokeName = ReadLine().ToLower().Trim();

            _apiString = $"https://pokeapi.co/api/v2/pokemon/{pokeName}/";

            var name = CatchPokemon.GetName(_apiString);
            var number = CatchPokemon.GetNumber(_apiString);
            WriteLine(name);
            WriteLine(number);
            ReadKey();

        }
    }
}

