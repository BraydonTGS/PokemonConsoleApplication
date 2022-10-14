using System;
using System.Linq;
using PokemonConsoleApp.Pokedex;
using PokemonConsoleApp.Pokemon_Obj;
using PokemonConsoleApp.PokemonsApi;
using PokemonConsoleApp.Printing;
using static System.Console;
namespace PokemonConsoleApp
{
    public class World
    {
        private string _apiString { get; set; }
        private PokeDex _pokemons { get; set; } = new PokeDex();
        private CatchPokemon _getPokemon { get; set; } = new CatchPokemon();

        public World()
        {

        }

        public void Run()
        {
            Print.PrintTitle();
            var pokeName = Print.PrintPrompt();
            IPokemon pokemon = _getPokemon.GetPokemon(pokeName);
            _pokemons.pokedex.Add(pokemon);
            Print.Loading();
            Print.PrintTitlePokemon();
            Print.PrintPokemon(pokemon);
            Print.Continue();
            ContinueSearch();
        }

        public void ContinueSearch()
        {
            Print.Loading();
            Print.PrintTitle();

            string prompt = "> Would you like to search again? ";
            string[] options = { "Yes", "No" };

            var selectedIndex = Print.PrintCustomMenu(prompt, options);

            if (selectedIndex == 0)
            {
                Run();
            }
            else if (selectedIndex == 1)
            {
                ExitGame();
            }
        }

        // Exit //
        public void ExitGame()
        {
            Print.PrintTitle();
            Print.Exit();
            ReadKey();
            Print.Loading();
            Environment.Exit(0);
        }
    }
}

