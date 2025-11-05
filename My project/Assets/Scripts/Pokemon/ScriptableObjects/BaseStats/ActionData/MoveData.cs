using UnityEngine;
using PokemonData.Values;
using UnityEngine.Serialization;

namespace PokemonData
{
    [CreateAssetMenu(fileName = "MoveData", menuName = "Pokemon/Move")]
    public class MoveData : ScriptableObject
    {
        public ActionType actionType = ActionType.Move; 
        public MoveName moveName; //move name
        public ActionCategory actionCategory; //move type
        public ElementType elementType; //element of the attack
        public int power; //the power of the attack
        public int accuracy; //the chance to hit the opponent
        public float powerPoints; //attack use number
        public Effects effects;
    }
}