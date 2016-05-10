namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;
    using WinterIsComing.Contracts;
    using WinterIsComing.Models.Spells;

    public class IceGiantCombatHandler : CombatHandler
    {
        public IceGiantCombatHandler(IUnit unit) 
            : base(unit)
        {
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets;
            if (this.Unit.HealthPoints <= 150)
            {
                targets = targets.Take(1);
            }

            return targets;
        }

        public override ISpell GenerateAttack()
        {
            var attack = new Stomp(this.Unit.AttackPoints);

            this.IsThereEnoughEnergy(attack);

            this.RemoveEnergyOnCast(attack);
            this.Unit.AttackPoints += 5;

            return attack;
        }
    }
}
