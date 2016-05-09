using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class CyclopsKing: Creature
    {
        private const int DefaultAttack = 17;
        private const int DefaultDefense = 13;
        private const int DefaultHealth = 70;
        private const decimal DefaultDamage = 18;

        public CyclopsKing() 
            : base(DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
