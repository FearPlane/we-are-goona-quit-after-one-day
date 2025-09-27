using UnityEngine;
using PokemonData.Values;

namespace PokemonData
{
    [CreateAssetMenu(fileName = "Ability", menuName = "Pokemon/Ability")]
    
    
    public class Ability : ScriptableObject
    {
        public enum AttackCategory
        {
            Physical, //use atk and def (damage formula)
            Special, //use sp.atk and sp.def (damage formula)
            Status //give effects
        }
        
        public Move move; //attack move
        public AttackCategory category; //attack type
        public ElementType elementType; //element of the attack
        public int power; //the power of the attack
        public int accuracy; //the chance to hit the opponent
        public float powerPoints; //attack use number
        public Effects effects;
    }
}