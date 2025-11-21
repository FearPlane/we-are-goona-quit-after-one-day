using System.Collections.Generic;
using PokemonGame.DataTransfer;
using PokemonGame.Pokemon;
using PokemonGame.Pokemon.Enums;

namespace PokemonGame.Inatances
{
    public sealed class PokemonInstance
    {
        public PokemonBase PokemonBase { get; set; }

        public Dictionary<BaseStatEnum, int> IvDictionary;
        public Dictionary<BaseStatEnum, int> EvDictionary;

        public BaseStatsInfo GetBaseStats() => new BaseStatsInfo(PokemonBase.hp, PokemonBase.attack,
            PokemonBase.specialAttack, PokemonBase.defense, PokemonBase.specialDefense, PokemonBase.speed);

        public PokedexDataInfo GetPokedexData() => new PokedexDataInfo(PokemonBase.pokemonName,
            PokemonBase.nationalNumber, PokemonBase.type, PokemonBase.species, PokemonBase.height, PokemonBase.weight,
            PokemonBase.level);
    }
}