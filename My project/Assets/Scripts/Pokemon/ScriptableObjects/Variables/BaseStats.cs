namespace PokemonData
{
    public enum BaseStats
    {
        hp,
        attackPower,
        defensePower,
        specialAtkPower,
        specialDefensePower,
        speed,
        total,
    }

    public struct StatYield
    {
        public BaseStats stat;
        public int value;
    }
}


