using UnityEngine;
using PokemonData.Values;
using UnityEngine.Serialization;

namespace PokemonData
{
    [CreateAssetMenu(fileName = "AbilityData", menuName = "Pokemon/Ability")]
    public class AbilityData : ScriptableObject
    {
        public ActionType actionType = ActionType.Ability;
        public ActionCategory actionCategory = ActionCategory.Status; //move type
        public AbilityName abilityName; //move name
        public ElementType elementType; //element of the attack
        public int accuracy; //the chance to hit the opponent
        public float powerPoints; //attack use number
        public Effects effects;
    }
}