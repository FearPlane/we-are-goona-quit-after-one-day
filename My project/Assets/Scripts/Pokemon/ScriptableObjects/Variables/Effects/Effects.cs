using Attribute;
using UnityEngine;

namespace PokemonData.Values
{
    [System.Serializable]
    public class Effects //Todo find the formulas for the effects and each stats
    {
        public EffectType type; //The kind of effect
        
        public EffectStatus status; //Which status condition to apply (only for statusCondition)
        public BattleStat stat; //Which stat to modify (only for `statChange`)

        public int _stages; //backing field
        
        public int Stages
        {
            get => _stages;
            set => _stages = (int)ValidateRange(value,-6,6);
        } //How many stages to raise/lower (for `statChange`)

        public int chance; //Probability that the effect occurs (percent)
        public EffectTarget target; //Who the effect applies top
        
        public float _value; //Extra numeric info (Heal, Recoil, FieldEffect, EntryHazard, Screen, MultiHit, Repeat, Charge, Priority, DelayNextTurn, Trap, Substitute) (each type's value effect on something else)
        public float Value
        {
            get => _value;
            set => _value = (int)ValidateRange(value, -6, 6);
        } //Extra numeric info (Heal, Recoil, FieldEffect, EntryHazard, Screen, MultiHit, Repeat, Charge, Priority, DelayNextTurn, Trap, Substitute) (each type's value effect on something else)
        
        public EffectDuration duration; //How long the effect lasts (turns) 

        public int _priority; //backing field
        public int Priority
        {
            get => _priority;
            set => _priority = (int)ValidateRange(value, -5, 2);
        }

        public int repeats; //Number of hits / repeated effect
        public FieldEffectType fieldEffectType; //A battlefield-wide effect that changes conditions of battle. Some field effects interact with ElementType (like weather/terrain), while others alter mechanics (like Trick Room, Reflect, hazards).
        public ItemEffectAction item; //Specifies which item is given, stolen, consumed, or created by the effect.
        public FormChangeTrigger form; //The form field usually appears in move/effect metadata when the move can change the form of a Pokémon. (for `formChange`)
        public TypeChange typeChange; //effect is used when a move, ability, or item changes the Pokémon’s type (or sometimes multiple types). (for `typeChange`) 
        
        private float ValidateRange(float value,float  min, float max)
        {
            if (value < min || value > max)
                throw new System.ArgumentOutOfRangeException(nameof(value),
                    "the value " + value + " range need to set around " + min + " to " + max +" include");
            return value;
        }
    }
    
}