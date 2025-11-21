using System.Collections.Generic;
using System.Linq;
using PokemonGame.Pokemon.Enums;
using PokemonGame.PokemonCore.Enums;

namespace PokemonGame.DataTransfer
{
    public sealed class PokedexDataInfo
    {
        public PokemonName PokemonName { get; }
        public int NationalNumber { get; }
        public IReadOnlyList<ElementType> Type { get; } // Normal,Fire,Water,Electric,etc...
        public Species Species { get; }
        public float Height { get; }
        public float Weight { get; }
        public int Level { get; }

        public PokedexDataInfo(PokemonName pokemonName, int nationalNumber, ElementType[] type, Species species,
            float height, float weight, int level)
        {
            PokemonName = pokemonName;
            NationalNumber = nationalNumber;
            Species = species;
            Height = height;
            Weight = weight;
            Level = level;
            Type = type?.ToList().AsReadOnly() ?? new List<ElementType>().AsReadOnly();
        }
    }
}