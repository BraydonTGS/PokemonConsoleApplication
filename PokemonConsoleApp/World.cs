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


            var pokemon = CatchPokemon.GetPokemon(_apiString);

            _pokemons.pokedex.Add(pokemon);


            object[] ary = { "1", 2, "string", 8, 'c' };

            WriteLine($"\n> Name: {pokemon.name}\n");
            WriteLine($"> Base Exp: {pokemon.base_experience}\n");
            pokemon.abilities.ForEach(x => WriteLine($"> Abilities: {x.ability.name}\n"));
            WriteLine($"> Height: {pokemon.height}\n");
            WriteLine($"> Items: {pokemon.held_items}\n");
            WriteLine($"> ID: {pokemon.id}\n");
            WriteLine($"> Location: {pokemon.location_area_encounters}\n");
            pokemon.types.ForEach(x => WriteLine($"> Type: {x.type.name}\n"));
            WriteLine($"> Weight: {pokemon.weight}\n");
            Console.ReadKey();






            Console.ReadKey();

        }
    }
}

