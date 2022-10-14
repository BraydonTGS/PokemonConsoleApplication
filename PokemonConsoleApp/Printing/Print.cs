using System;
using PokemonConsoleApp.Pokemon_Obj;
using static System.Console;
namespace PokemonConsoleApp.Printing
{
    public static class Print
    {
        public static void PrintTitle()
        {
            Clear();
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("------------------------------------------------------------------------\n");
            WriteLine(@"██████╗  ██████╗ ██╗  ██╗███████╗██████╗ ███████╗██╗  ██╗
██╔══██╗██╔═══██╗██║ ██╔╝██╔════╝██╔══██╗██╔════╝╚██╗██╔╝
██████╔╝██║   ██║█████╔╝ █████╗  ██║  ██║█████╗   ╚███╔╝ 
██╔═══╝ ██║   ██║██╔═██╗ ██╔══╝  ██║  ██║██╔══╝   ██╔██╗ 
██║     ╚██████╔╝██║  ██╗███████╗██████╔╝███████╗██╔╝ ██╗
╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═════╝ ╚══════╝╚═╝  ╚═╝
                                                         ");
            WriteLine("------------------------------------------------------------------------");
            ForegroundColor = previousColor;
        }

        // Print Pokemon //
        public static void PrintTitlePokemon()
        {
            Clear();
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("------------------------------------------------------------------------\n");
            WriteLine(@"██████╗  ██████╗ ██╗  ██╗███████╗███╗   ███╗ ██████╗ ███╗   ██╗
██╔══██╗██╔═══██╗██║ ██╔╝██╔════╝████╗ ████║██╔═══██╗████╗  ██║
██████╔╝██║   ██║█████╔╝ █████╗  ██╔████╔██║██║   ██║██╔██╗ ██║
██╔═══╝ ██║   ██║██╔═██╗ ██╔══╝  ██║╚██╔╝██║██║   ██║██║╚██╗██║
██║     ╚██████╔╝██║  ██╗███████╗██║ ╚═╝ ██║╚██████╔╝██║ ╚████║
╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
                                                               ");
            ForegroundColor = previousColor;
        }

        // Print Prompt //
        public static string PrintPrompt()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            Write("\n> Please Enter The Name You want to Search For: ");
            var name = ReadLine()?.ToLower().Trim();
            ForegroundColor = prevColor;
            return name;

        }

        // Printing a Custom Menu //
        public static int PrintCustomMenu(string prompt, string[] options)
        {
            MenuPrinter selection = new MenuPrinter(prompt, options);
            int index = selection.Run();
            return index;
        }

        // Print Pokemon //
        public static void PrintPokemon(IPokemon pokemon)
        {
            ForegroundColor = ConsoleColor.Yellow;

            WriteLine($"----------------------->  Name: {pokemon.name}  <-------------------------\n");
            WriteLine($"> Name: {pokemon.name}\n");
            WriteLine($"> Base Exp: {pokemon.base_experience}\n");
            pokemon.abilities.ForEach(x => WriteLine($"> Abilities: {x.ability.name}\n"));
            WriteLine($"> Height: {pokemon.height}\n");
            WriteLine($"> ID: {pokemon.id}\n");
            WriteLine($"> Location: {pokemon.location_area_encounters}\n");
            pokemon.types.ForEach(x => WriteLine($"> Type: {x.type.name}\n"));
            WriteLine($"> Weight: {pokemon.weight}\n");
            WriteLine($"--------------------------------------------------------");
        }


        // Loading //
        public static void Loading()
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            Write("\n> Loading Please Wait");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                Write(".");
            }
            WriteLine();
            ForegroundColor = previousColor;
        }


        // Press Enter to Continue //
        public static void Continue()
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            Write("\n> Press Any Key To Continue... ");
            ReadKey();
            WriteLine();
            ForegroundColor = previousColor;
        }


        // Exit the Program //
        public static void Exit()
        {
            string exit = "\n> Thank you.\n\n> Please Press Any Key To Exit: ";
            PrintCharacters(exit);
        }


        // Method for Printing one character at at time //
        public static void PrintCharacters(string input)
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < input.Length; i++)
            {
                Write(input[i]);
                Thread.Sleep(65);

                // Skip to the End of the String //
                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Write(input.Substring(i + 1));
                        break;
                    }
                }
            }
            WriteLine();
            ForegroundColor = previousColor;
        }
    }
}


