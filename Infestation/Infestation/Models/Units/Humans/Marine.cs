namespace Infestation.Models.Units.Humans
{
    using System.Collections.Generic;
    using System.Linq;
    using Infestation.Models.Supplements;

    public class Marine : Human
    {
        public Marine(string id)
            : base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            var target = attackableUnits.Where(u => u.Power <= this.Aggression)
                .OrderByDescending(u => u.Health)
                .FirstOrDefault();
            
            return target;
        }
    }
}
