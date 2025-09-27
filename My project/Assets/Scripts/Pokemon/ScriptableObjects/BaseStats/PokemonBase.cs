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

        [Header("Pokédex data")] public int nationalNumber;
        public ElementType[] type;
        public Species species;
        public int height;
        public int weight;
        public int level;
        public Ability[] abilities;

        [Header("Training")] //states 
        public Stat[] evYield;

        public float catchRate;
        public int baseFriendship;
        public int baseExp;
        public GrowthRate growthRate;

        [Header("breeding")] 
        public ElementType eggGroups;
        public GenderRatio genderRatio;
        public int eggCycles;


        [Header("Effectiveness")] public VulnerableChart vulnerableChart;
    }
}
