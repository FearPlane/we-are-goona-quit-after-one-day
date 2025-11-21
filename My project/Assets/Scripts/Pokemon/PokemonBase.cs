using UnityEngine;
using PokemonGame.Pokemon.Data;
using PokemonGame.Pokemon.Enums;
using PokemonGame.PokemonCore.Enums;
using Unity.VisualScripting;

namespace PokemonGame.Pokemon
{
    [CreateAssetMenu(fileName = "PokemonBase", menuName = "Pokemon/PokemkonBase")]
    public sealed class PokemonBase : ScriptableObject
    {
        [Header("base stats")] 
        public BaseStat hp;
        public BaseStat attack;
        public BaseStat specialAttack;
        public BaseStat defense;
        public BaseStat specialDefense;
        public BaseStat speed;
        
        [Space(15)]
        public int total;
        
        [Header("Pokedex data")]
        public PokemonName pokemonName;
        public int nationalNumber;
        public ElementType[] type; // Normal,Fire,Water,Electric,etc...
        public Species species;
        public float height;
        public float weight;
        public int level;
        public ScriptableObject[] actionData;

        [Header("Training")]
        public Stat[] evYield;
        public float catchRate;
        public int baseFriendship;
        public int baseExp;
        public GrowthRate growthRate;

        [Header("breeding")] 
        public EggGroup[] eggGroups;
        public GenderRatio genderRatio;
        public int eggCycles;

        [Header("Evolution")] 
        public ScriptableObject evolutionPokemon; //Todo check if iv and ev is effected when pokemon is evolved
    }
}
