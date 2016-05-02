using System.Collections.Generic;
using System.Linq;

namespace Infestation.Models.Units
{
    public abstract class InfestorUnit : Unit
    {
        protected InfestorUnit(string id, UnitClassification unitType, int health, int power, int aggression) 
            : base(id, unitType, health, power, aggression)
        {
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            var target = attackableUnits
                .Where(u => u.Id != this.Id)
                .OrderBy(u => u.Health)
                .FirstOrDefault();

            return target;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units;

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }
    }
}
