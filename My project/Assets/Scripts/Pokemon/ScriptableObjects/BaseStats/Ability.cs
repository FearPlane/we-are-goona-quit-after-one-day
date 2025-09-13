using UnityEngine;

namespace PokemonData
{
    [CreateAssetMenu(fileName = "Ability", menuName = "Pokemon/Ability")]
    
    
    public class Ability : ScriptableObject
    {
        public enum Category
        {
            Physical, //use atk and def (damage formula)
            Special, //use sp.atk and sp.def (damage formula)
            Status //give effects
        }
        
        public Move move;
        public Category category;
        public ElementType elementType;
        public int power;
        public int accuracy;
        public float powerPoints;
        //Effects: { chance: 10%, status: PARALYSIS }
    }
}