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
                abilities = response.abilities,
                base_experience = response.base_experience,
                height = response.height,
                id = response.id,
                location_area_encounters = response.location_area_encounters,
                moves = response.moves,
                sprites = response.sprites,
                stats = response.stats,
                types = response.types,
                weight = response.weight

            };

        }

    }
}



