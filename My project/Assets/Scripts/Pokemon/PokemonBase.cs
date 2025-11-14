using UnityEngine;
using PokemonGame.Pokemon.Data;
using PokemonGame.Pokemon.Enums;
using PokemonGame.PokemonCore.Enums;

namespace PokemonGame.Pokemon
{
    [CreateAssetMenu(fileName = "PokemonBase", menuName = "Pokemon/PokemkonBase")]
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


        [Header("Effectiveness")] 
        public VulnerableChartData vulnerableChart;
    }
}
