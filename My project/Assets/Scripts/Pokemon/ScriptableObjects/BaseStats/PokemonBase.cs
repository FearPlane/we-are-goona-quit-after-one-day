using PokemonData;
using UnityEngine;

[CreateAssetMenu(fileName = "PokemonData",menuName = "Pokemon/PokemkonData")]
public class PokemonBase : ScriptableObject
{
    [Header("base stats")]
    public int hp;
    public int attackPower;
    public int defensePower;
    public int specialAtkPower;
    public int specialDefensePower;
    public int speed;
    public int total;
    
    [Header("Pokédex data")]
    public int nationalNumber;
    public elementType[] type;
    public species species;
    public int height;
    public int weight;
    public abilities[] abilities;

    [Header("Training")] //states 
    public StatYield[] evYield;
    public float catchRate;
    public int baseFriendship;
    public int baseExp;
    public growthRate growthRate;

    [Header("breeding")]
    public elementType eggGroups;
    public GenderRatio genderRatio;
    public int eggCycles;


    [Header("Effectiveness")] 
    public VulnerableTypes vulnerableTypes;
}
