using UnityEngine;
using PokemonGame.Effects;
using PokemonGame.Move.Enums;
using PokemonGame.PokemonCore.Enums;

namespace PokemonGame.Move
{
    [CreateAssetMenu(fileName = "MoveData", menuName = "Pokemon/Move")]
    public class MoveBase : ScriptableObject
    {
        public ActionType actionType = ActionType.Move;
        public ActionCategory actionCategory; //move type
        public MoveName moveName; //move name
        public ElementType elementType; //element of the attack
        public int power; //the power of the attack
        public int accuracy; //the chance to hit the opponent
        public float powerPoints; //attack use number
        public EffectsData effects;
    }
}