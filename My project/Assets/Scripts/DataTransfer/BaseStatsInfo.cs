using PokemonGame.Pokemon.Data;

namespace PokemonGame.DataTransfer
{
    public sealed class BaseStatsInfo
    {
        public BaseStat Hp { get; }
        public BaseStat Attack { get; }
        public BaseStat SpecialAttack { get; }
        public BaseStat Defense { get; }
        public BaseStat SpecialDefense { get; }
        public BaseStat Speed { get; }
        
        public BaseStatsInfo(BaseStat hp, BaseStat attack, BaseStat specialAttack,BaseStat defense, BaseStat specialDefense, BaseStat speed)
        {
            Hp = hp;
            Attack = attack;
            SpecialAttack = specialAttack;
            Defense = defense;
            SpecialDefense = specialDefense;
            Speed = speed;
        }
    }
}