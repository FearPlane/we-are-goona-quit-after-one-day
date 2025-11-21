using PokemonGame.DataTransfer;
using PokemonGame.Inatances;
using PokemonGame.PokemonCore.Enums;

namespace Formulas
{
    public class Damage
    {
        public int DamageCalculator(PokemonInstance attacker,PokemonInstance defender,ActionDataInfo actionData)
        {
            float mod = 0;

            if (actionData.ActionCategory == ActionCategory.Physical)
                return (((2 * attacker.GetPokedexData().Level / 5 + 2) * (actionData.Power * attacker.GetBaseStats().Attack.value / (50 * defender.GetBaseStats().Defense.value))) + 2) * (int)mod;
            
            return (((2 * attacker.GetPokedexData().Level / 5 + 2) * (actionData.Power * attacker.GetBaseStats().SpecialAttack.value / (50 * defender.GetBaseStats().SpecialDefense.value))) + 2) * (int)mod;
        }
    }
}