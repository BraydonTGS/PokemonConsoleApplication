using System;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using PokemonConsoleApp.Pokemon_Obj;


namespace PokemonConsoleApp.PokemonsApi
{
    // PokeAPIClient // 
    public class CatchPokemon
    {
        // init client //
        private readonly string _apiURL = $"https://pokeapi.co/api/v2/pokemon/";

        public Pokemon GetPokemon(string pokeName)
        {
            var client = new HttpClient();
            var repo = client.GetStringAsync(_apiURL + pokeName).Result;
            var response = JsonSerializer.Deserialize<Pokemon>(repo);
            var responseTest = JsonSerializer.Deserialize<PokeApiResponse>(repo);

            return new Pokemon()
            {
                name = responseTest.name,
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

        // I can add other methods here for API responses //



    }
}



