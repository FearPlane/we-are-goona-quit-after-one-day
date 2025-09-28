using UnityEngine;
using PokemonData.Values;

namespace PokemonData
{
    [CreateAssetMenu(fileName = "Ability", menuName = "Pokemon/Ability")]
    
    
    public class Ability : ScriptableObject
    {
        public Move move; //move name
        public MoveCategory category; //move type
        public ElementType elementType; //element of the attack
        public int power; //the power of the attack
        public int accuracy; //the chance to hit the opponent
        public float powerPoints; //attack use number
        public Effects effects;
    }
}