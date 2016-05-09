using System.Linq;

namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;

    public class ExtendBattleManager : BattleManager
    {
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        public ExtendBattleManager(ICreaturesFactory creaturesFactory, ILogger logger) 
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
            }
            else
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }
            else
            {
                return base.GetByIdentifier(identifier);
            }           
        }
    }
}
