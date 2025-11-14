using PokemonGame.Effects.Enums;

namespace PokemonGame.Effects.Data
{
    [System.Serializable]
    public class TypeChange
    {
        public TypeChangeSource typeChangeSource; //what type to change of the enemy Todo Check when the type is been affected 
        /*
         * so when does the change source is been affected?
            because when using the soak for example when the type is changeing the type of the trigger into water
            but what if my pokemon dont support water
         */
        
        public TypeChangeTrigger typeChangeTrigger; //the type to be changed
    }
}