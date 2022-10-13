using System;
using System.Linq;
using PokemonConsoleApp.Pokemons;
using PokemonConsoleApp.Printing;
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
            Print.PrintTitle();
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            Write("\n> Please Enter The Name You want to Search For: ");
            var pokeName = ReadLine()?.ToLower().Trim();
            ForegroundColor = prevColor;

            _apiString = $"https://pokeapi.co/api/v2/pokemon/{pokeName}/";


            var pokemon = CatchPokemon.GetPokemon(_apiString);

            _pokemons.pokedex.Add(pokemon);

            Print.Loading();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"----------------------------------------------------------------\n");
            WriteLine($"> Name: {pokemon.name}\n");
            WriteLine($"> Base Exp: {pokemon.base_experience}\n");
            pokemon.abilities.ForEach(x => WriteLine($"> Abilities: {x.ability.name}\n"));
            WriteLine($"> Height: {pokemon.height}\n");
            WriteLine($"> Items: {pokemon.held_items}\n");
            WriteLine($"> ID: {pokemon.id}\n");
            WriteLine($"> Location: {pokemon.location_area_encounters}\n");
            pokemon.types.ForEach(x => WriteLine($"> Type: {x.type.name}\n"));
            WriteLine($"> Weight: {pokemon.weight}\n");
            WriteLine($"----------------------------------------------------------------");
            Console.ReadKey();






            Console.ReadKey();

        }
    }
}

