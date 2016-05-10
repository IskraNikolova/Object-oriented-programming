namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using WinterIsComing.Models.Spells;
    using System.Linq;
    using WinterIsComing.Contracts;

    public class WarriorCombatHandler : CombatHandler
    {
        private const int DefaultHealthPoints = 80;
        public WarriorCombatHandler(IUnit unit) 
            : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var target = candidateTargets
                .OrderBy(c => c.HealthPoints)
                .ThenBy(c => c.Name)
                .Take(1);

            return target;
        }

        public override ISpell GenerateAttack()
        {
            int damage = this.Unit.AttackPoints;
            if (this.Unit.HealthPoints <= DefaultHealthPoints)
            {
                damage += (this.Unit.HealthPoints*2);
            }
            var spell = new Cleave(damage);
            this.IsThereEnoughEnergy(spell);

            this.RemoveEnergyOnCast(spell);

            return spell;
        }
    }
}
