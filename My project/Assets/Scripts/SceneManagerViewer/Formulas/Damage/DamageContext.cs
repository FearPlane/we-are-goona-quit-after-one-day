namespace Pokemon
{
    public class DamageContext
    {
        public int attackerLevel { get; }
        public int attackerAbilityPower { get; }
        public int attackerAttackPower { get; }
        public int targetDefencePower { get; }
        public float targetElementVulnerableValue { get; }

        public DamageContext(
            int _attackerLevel,
            int _attackerAbilityPower,
            int _attackerAttackPower,
            int _targetDefencePower,
            float _targetElementVulnerableValue
        )
        {
            this.attackerLevel = _attackerLevel;
            this.attackerAbilityPower = _attackerAbilityPower;
            this.attackerAttackPower = _attackerAttackPower;
            this.targetDefencePower = _targetDefencePower;
            this.targetElementVulnerableValue = _targetElementVulnerableValue;
        }
    }
}