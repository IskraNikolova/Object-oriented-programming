using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class IceGiant : Unit
    {
        private const int DefaultAttackPoints = 150;
        private const int DefaultHealthPoints = 300;
        private const int DefaultDefencePoints = 60;
        private const int DefaultEnergy = 50;
        private const int DefaultRange = 1;

        public IceGiant(UnitType type, string name, int x, int y)
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
            this.CombatHandler = new IceGiantCombatHandler(this);
        }
    }
}
