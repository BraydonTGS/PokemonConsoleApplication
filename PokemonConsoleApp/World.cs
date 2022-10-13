﻿using System;
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


            var pokemon = CatchPokemon.GetPokemon(_apiString);

            Console.WriteLine(pokemon);
            Console.WriteLine(pokemon.Name);
            Console.WriteLine(pokemon.Abilities);

            Console.ReadKey();

        }
    }
}

