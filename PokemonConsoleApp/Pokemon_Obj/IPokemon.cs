using System;
namespace PokemonConsoleApp.Pokemon_Obj
{
    public interface IPokemon
    {

        List<Ability>? abilities { get; set; }
        int base_experience { get; set; }
        int height { get; set; }
        List<object>? held_items { get; set; }
        int id { get; set; }
        string? location_area_encounters { get; set; }
        List<Move>? moves { get; set; }
        string? name { get; set; }
        int order { get; set; }
        List<object>? past_types { get; set; }
        Sprites? sprites { get; set; }
        List<Stat>? stats { get; set; }
        List<Type>? types { get; set; }
        int weight { get; set; }

    }
}

