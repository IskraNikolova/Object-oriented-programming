using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class Mage : Unit
    {
        private const int DefaultAttackPoints = 80;
        private const int DefaultHealthPoints = 80;
        private const int DefaultDefencePoints = 40;
        private const int DefaultEnergy = 120;
        private const int DefaultRange = 2;

        public Mage(UnitType type, string name,  int x, int y)
           : base(
                 type,
                 name,
                 x, 
                 y, 
                 DefaultAttackPoints, 
                 DefaultHealthPoints, 
                 DefaultDefencePoints, 
                 DefaultEnergy, 
                 DefaultRange)
        {
            this.CombatHandler = new MageCombatHandler(this);
        }
    }
}
