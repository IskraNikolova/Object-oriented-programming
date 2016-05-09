namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            this.rounds = rounds;
        }

        public int Rounds
        {
            get
            {
                return this.rounds;
            }

            private set
            {
                if (value <= 0 && value > 10)
                {
                    throw new ArgumentOutOfRangeException(
                        "rounds", 
                        "The number of rounds should be greater than 0 and less or equal than 10");
                }

                this.rounds = value;
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
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.Rounds <= 0)
            {
                return currentDamage;
            }

            this.Rounds--;
            currentDamage *= 2;

            return base.ChangeDamageWhenAttacking(attackerWithSpecialty, defender, currentDamage);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.Rounds);
        }
    }
}
