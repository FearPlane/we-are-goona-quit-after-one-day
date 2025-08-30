namespace Pokemon
{
    public static class Formulas //fight sence
    {
        public static float Damage(DamageContext damageContext)
        {
            float modifier = damageContext.targetVulnerableValue;

            return (((((2 * damageContext.attackerLevel / 5) + 2) * damageContext.abilityPower *
                damageContext.attackerAttackPower / damageContext.attackedDefencePower) / 50) + 2) * modifier;
        }
    }
}