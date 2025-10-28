namespace PokemonData.Values
{
    public enum BattleStat
    {
        Attack,
        Defense,
        SpecialAttack,
        SpecialDefense,
        Speed,
        Accuracy,
        Evasion //Evasion controls how likely a Pokémon is to avoid being hit by an opponent’s move.
    }

    [System.Serializable]
    public class Stat
    {
        public BattleStat stat;
        public int value;
    }
}


