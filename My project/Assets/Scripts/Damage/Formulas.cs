namespace PokemonGame.Damage
{
    public static class Formulas //fight sence
    {
        public static float Damage(DamageContext damageContext)
        {
            float modifier = damageContext.targetElementVulnerableValue;

            return (((((2 * damageContext.attackerLevel / 5) + 2) * damageContext.attackerAbilityPower *
                damageContext.attackerAttackPower / damageContext.targetDefencePower) / 50) + 2) * modifier;
        }
    }
}