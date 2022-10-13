using System;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace PokemonConsoleApp.Pokemons
{
    public class CatchPokemon

    {
        public static Pokemon GetPokemon(string apiCall)
        {
            var client = new HttpClient();
            var repo = client.GetStringAsync(apiCall).Result;
            var response = JsonSerializer.Deserialize<Pokemon>(repo);

            return new Pokemon()
            {
                name = response.name,
                base_experience = response.base_experience,
                height = response.height,
                id = response.id,
                held_items = response.held_items,
                location_area_encounters = response.location_area_encounters,
                Order = response.Order,
                weight = response.weight,
            };

        }

        public static string GetName(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var name = JObject.Parse(response)["name"]?.ToString() ?? "Null";
            return name;
        }

        public static string GetType(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var type = JObject.Parse(response)?["types"]?[0]?["type"]?["name"]?.ToString() ?? "Null";

            return type;
        }

        public static int GetNumber(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var number = int.Parse(JObject.Parse(response)?["id"]?.ToString() ?? "Null");

            return number;
        }

        public static string GetSprite(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var sprite = JObject.Parse(response)?["sprites"]?["back_default"]?.ToString() ?? "Null";

            return sprite;
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


    }
}



