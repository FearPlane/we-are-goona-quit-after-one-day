namespace PokemonData
{
    public enum baseStats
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
        public baseStats stat;
        public int value;
    }
}


