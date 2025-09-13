namespace PokemonData
{
    public enum BaseStats
    {
        Hp,
        AttackPower,
        DefensePower,
        SpecialAtkPower,
        SpecialDefensePower,
        Speed,
        Total,
    }

    public class Stat
    {
        public BaseStats stat;
        public int value;
    }
}


