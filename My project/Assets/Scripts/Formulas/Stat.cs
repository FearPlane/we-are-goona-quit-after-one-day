namespace Formulas
{
    public class Stat
    {
        public int RegularStat(int baseStat,int iv,int ev,int level)
        {
            return (((baseStat * 2 + iv + (ev / 4)) * level) / 100) + 5; // Todo * nature
        }

        public int HpStat(int hpBaseStat,int ivHp,int evHp,int level)
        {
            return (((hpBaseStat * 2 + ivHp + (evHp / 4)) * level) / 100) + level + 10;
        }
    }
}