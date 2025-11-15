using System.Collections.Generic;
using PokemonGame.Pokemon;
using PokemonGame.Pokemon.Enums;

namespace PokemonGame.PokemonCore.Instances
{
    public class PokemonInstance
    {
        public PokemonBase pokemonBase { get; set; }

        public Dictionary<BaseStatEnum, int> IvDictionary;
        public Dictionary<BaseStatEnum, int> EvDictionary;
    }
}