using System.Globalization;

namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class AddAttackWhenSkip : Specialty

    {
        private int attackPointsToAdded;

        public AddAttackWhenSkip(int attackPointsToAdded)
        {
            this.AttackPointsToAdded = attackPointsToAdded;
        }

        public int AttackPointsToAdded
        {
            get
            {
                return this.attackPointsToAdded;
                
            }
            private set
            {
                if (value < 1 && value > 10)
                {
                    throw new ArgumentOutOfRangeException(
                        "attackPOintToAdded",
                        "The number of attack points should be in range [1...10].");
                }

                this.attackPointsToAdded = value;
            }
        }
        
        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
        }

        public override void ApplyWhenDefending(ICreaturesInBattle defenderWithSpecialty, ICreaturesInBattle attacker)
        {
        }

        public override void ApplyAfterDefending(ICreaturesInBattle defenderWithSpecialty)
        {
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackPointsToAdded;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.AttackPointsToAdded);
        }
    }
}
