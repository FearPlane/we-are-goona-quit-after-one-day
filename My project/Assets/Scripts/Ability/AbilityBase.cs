using PokemonGame.Ability.Enums;
using UnityEngine;
using PokemonGame.Effects;
using PokemonGame.PokemonCore.Enums;

namespace PokemonGame.Ability
{
    [CreateAssetMenu(fileName = "AbilityData", menuName = "Pokemon/Ability")]
    public sealed class AbilityBase : ScriptableObject
    {
        public ActionType actionType = ActionType.Ability;
        public ActionCategory actionCategory = ActionCategory.Status; //move type
        public AbilityName abilityName; //move name
        public ElementType elementType; //element of the attack
        public int accuracy; //the chance to hit the opponent
        public int powerPoints; //attack use number
        public EffectsData effects;
    }
}