
namespace Empires.Models.Units
{
    public class Swordsman : Unit
    {
        private const int SwordsmanHealth = 40;
        private const int SwordsmanAttackDamage = 13;

        public Swordsman()
            : base(SwordsmanHealth, SwordsmanAttackDamage)
        {
        }
    }
}
