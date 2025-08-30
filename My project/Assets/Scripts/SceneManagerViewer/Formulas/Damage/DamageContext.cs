namespace Pokemon
{
    public class DamageContext
    {
        public int attackerLevel { get; }
        public int abilityPower { get; }
        public int attackerAttackPower { get; }
        public int attackedDefencePower { get; }
        public float targetVulnerableValue { get; }

        public DamageContext(
            int _attackerLevel,
            int _movePower,
            int _attackerAttackStat,
            int _attackedDefenceStat,
            float _vulnerableValue
        )
        {
            this.attackerLevel = _attackerLevel;
            this.abilityPower = _movePower;
            this.attackerAttackPower = _attackerAttackStat;
            this.attackedDefencePower = _attackedDefenceStat;
            this.targetVulnerableValue = _vulnerableValue;
        }
    }
}