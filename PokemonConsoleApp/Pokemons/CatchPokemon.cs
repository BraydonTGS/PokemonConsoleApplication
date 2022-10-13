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
            var response = JsonSerializer.Deserialize<Pokemon>(client.GetStringAsync(apiCall).Result);

            return new Pokemon()
            {
                Name = response.Name,
                Types = response.Types,
                Abilities = response.Abilities,
                BaseExperience = response.BaseExperience,
                Height = response.Height,
                Id = response.Id,
                HeldItems = response.HeldItems,
                LocationAreaEncounters = response.LocationAreaEncounters,
                Order = response.Order,
                Weight = response.Weight,
                Sprites = response.Sprites,

            };

        }


    }
}



