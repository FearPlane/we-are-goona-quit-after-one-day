using UnityEngine;

namespace PokemonData
{
    [CreateAssetMenu(fileName = "Ability", menuName = "Pokemon/Ability")]
    public class Ability : ScriptableObject
    {
        public string abilityName;
        public Move move;
        public ElementType elementType;
        public int power;
        public float useCount;
    }
}