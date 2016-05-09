namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int DefaultAttack = 8;
        private const int DefaultDefense = 8;
        private const int DefaultHealth = 25;
        private const decimal DefaultDamage = 4.5m;

        private const int DefaultRound = 5;
        private const int DefaultDefencePoints = 3;

        public Griffin() 
            : base(DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(DefaultRound));
            this.AddSpecialty(new AddDefenseWhenSkip(DefaultDefencePoints));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
