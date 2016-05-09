namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        private const int DefaultAttack = 19;
        private const int DefaultDefense = 19;
        private const int DefaultHealth = 300;
        private const decimal DefaultDamage = 40;
        private const int BehemothEnemyDefenseReductionPercentage = 80;
        private const int DefaultRounds = 5;

        public AncientBehemoth() 
            : base(DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(BehemothEnemyDefenseReductionPercentage));
            this.AddSpecialty(new DoubleDefenseWhenDefending(DefaultRounds));
        }
    }
}
