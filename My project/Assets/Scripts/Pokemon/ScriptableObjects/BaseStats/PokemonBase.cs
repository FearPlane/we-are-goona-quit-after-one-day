using PokemonData;
using UnityEngine;
using PokemonData.Values;

namespace PokemonData
{
    [CreateAssetMenu(fileName = "PokemonData", menuName = "Pokemon/PokemkonData")]
    public class PokemonBase : ScriptableObject
    {
        [Header("base stats")] 
        public float hp;
        public int attackPower;
        public int defensePower;
        public int specialAtkPower;
        public int specialDefensePower;
        public int speed;
        public int total;

        [Header("Pokédex data")]
        public string pokemonName;
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
        public ElementType[] eggGroups; //Todo check about the type elementtype for the eggGroup maybe the type isnt fit
        public GenderRatio genderRatio;
        public int eggCycles;


        [Header("Effectiveness")] 
        public VulnerableChart vulnerableChart;
    }
}
