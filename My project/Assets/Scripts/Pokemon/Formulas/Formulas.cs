namespace Pokemon
{
    public class Formulas //fight sence
    {
        private DamageContext damageContext = new DamageContext();
        
        public float Damage()
        {
            float modifier = damageContext.vulnerableValue;

            return (((((2 * damageContext.attackerLevel / 5) + 2) * damageContext.movePower *
                damageContext.attackerAttackStat / damageContext.attackedDefenceStat) / 50) + 2) * modifier;
        }
    }
}