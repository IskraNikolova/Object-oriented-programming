using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Contracts;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    public class MageCombatHandler : CombatHandler
    {
        private bool IsFireBreath = true;
        public MageCombatHandler(IUnit unit) : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets
                .OrderByDescending(c => c.HealthPoints)
                .ThenBy(c => c.Name)
                .Take(3);

            return targets;
        }

        public override ISpell GenerateAttack()
        {
            ISpell spell = null;
            int damage = 0; 
            if (IsFireBreath)
            {
                damage = this.Unit.AttackPoints;
                spell = new FireBreath(damage);
                this.IsThereEnoughEnergy(spell);
                this.IsFireBreath = !this.IsFireBreath;
            }
            else
            {
                damage = this.Unit.AttackPoints*2;
                spell = new Blizzard(damage);
                this.IsThereEnoughEnergy(spell);
                this.IsFireBreath = !this.IsFireBreath;
            }

            this.RemoveEnergyOnCast(spell);

            return spell;
        }
    }
}
