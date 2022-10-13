using System;
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
            WriteLine("------------------------------------------------------------------------");
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


