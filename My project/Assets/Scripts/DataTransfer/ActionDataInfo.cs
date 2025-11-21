using PokemonGame.Effects;
using PokemonGame.PokemonCore.Enums;

namespace PokemonGame.DataTransfer
{
    public sealed class ActionDataInfo
    {
        public ActionCategory ActionCategory { get; }
        public string ActionName { get; }
        public ElementType ElementType { get; }
        public int Power { get; }
        public EffectsData Effects { get; }

        public ActionDataInfo(ActionCategory actionCategory, string actionName,ElementType elementType,int power,EffectsData effects)
        {
            ActionCategory = actionCategory;
            ActionName = actionName;
            ElementType = elementType;
            Power = power;
            Effects = effects;
        }
    }
}