using System;
using System.Globalization;
using ArmyOfCreatures.Extended.Creatures;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Extended
{
    public class ExtendCreaturesFactory : CreaturesFactory
    {
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "ArchDevil":
                    return new ArchDevil();
                case "Goblin":
                    return new Goblin();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                    return base.CreateCreature(name);
            }    
        }
    }
}
