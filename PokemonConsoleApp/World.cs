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




            WriteLine($"> Name: {pokemon.name}");
            WriteLine($"> Base Exp: {pokemon.base_experience}");
            WriteLine($"> Abilities: {pokemon.abilities.Select(item => item.ability)}");
            WriteLine($"> Height: {pokemon.height}");
            WriteLine($"> Items: {pokemon.held_items}");
            WriteLine($"> ID: {pokemon.id}");
            WriteLine($"> Location: {pokemon.location_area_encounters}");
            WriteLine($"> Type:  {pokemon.types}");
            WriteLine($"> Weight: {pokemon.weight}");
            Console.ReadKey();






            Console.ReadKey();

        }
    }
}

