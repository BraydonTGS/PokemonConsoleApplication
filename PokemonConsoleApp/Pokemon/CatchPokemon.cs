using System;
using Newtonsoft.Json.Linq;

namespace PokemonConsoleApp.Pokemon
{
    public static class CatchPokemon
    {
        public static string GetName(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var name = JObject.Parse(response)["name"]?.ToString() ?? "Null";

            return name;
        }

        public static string GetType()
        {
            return "";
        }
        public static int GetNumber(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var number = int.Parse(JObject.Parse(response)?["id"]?.ToString() ?? "Null");

            return number;
        }
        public static List<string> GetAbilities(string apiCall)
        {
            var moves = new List<string>();
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var move1 = JObject.Parse(response)?["abilities"]?[0]?["ability"]?["name"]?.ToString() ?? "Null";
            var move2 = JObject.Parse(response)["abilities"]?[1]?["ability"]?["name"]?.ToString() ?? "Null";
            moves.Add(move1);
            moves.Add(move2);
            return moves;
        }
        public static string GetSprite()
        {
            return "";
        }
    }
}



