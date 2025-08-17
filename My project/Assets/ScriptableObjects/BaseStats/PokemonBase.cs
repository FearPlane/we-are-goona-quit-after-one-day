using PokemonData;
using UnityEngine;

[CreateAssetMenu(fileName = "PokemonData",menuName = "Pokemon/PokemkonData")]
public class PokemonBase : ScriptableObject
{
    //pokemon base stats
    [Header("base stats")]
    public baseStats hp;
    public baseStats attackPower;
    public baseStats defensePower;
    public baseStats specialAtkPower;
    public baseStats specialDefensePower;
    public baseStats speed;
    public baseStats total;
    
    [Header("Pokédex data")]
    public int nationalNumber;
    public elementType[] type;
    public species species;
    public int height;
    public int weight;
    public abilities[] abilities;

    [Header("Training")] 
    public baseStats[] evYield;
    public float catchRate;
    public int baseFriendship;
    public int baseExp;
    public growthRate growthRate;

    [Header("breeding")]
    public elementType eggGroups;
    public Vector2 gender; //left for man right for women
    public int eggCycles;
}
