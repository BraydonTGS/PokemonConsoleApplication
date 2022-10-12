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
            var name = JObject.Parse(response)["name"]?.ToString() ?? "Error";

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
            var number = int.Parse(JObject.Parse(response)["id"]?.ToString());

            return number;
        }
        public static IEnumerable<string> GetAbilities()
        {
            return null;
        }
        public static string GetSprite()
        {
            return "";
        }
    }
}




//public static double GetTemp(string apiCall)
//{
//    var client = new HttpClient();

//    var response = client.GetStringAsync(apiCall).Result;

//    var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

//    return temp;

//}

