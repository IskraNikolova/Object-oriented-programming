using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class Warrior : Unit
    {
        private const int DefaultAttackPoints = 120;
        private const int DefaultHealthPoints = 180;
        private const int DefaultDefencePoints = 70;
        private const int DefaultEnergy = 60;
        private const int DefaultRange = 1;

        public Warrior(UnitType type, string name,  int x, int y) 
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
            this.CombatHandler = new WarriorCombatHandler(this);
        }
    }
}
