using System;
using Infestation.Interfaces;
using Infestation.Models.Supplements;
using Infestation.Models.Units;
using Infestation.Models.Units.Humans;

namespace Infestation
{
    public class ExtendingHoldingPen : HoldingPen
    {
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            string unitId = commandWords[2];
            switch (commandWords[1])
            {
                case "Marine":
                    var marine = new Marine(unitId);
                    this.InsertUnit(marine);
                    break;
                case "Tank":
                    var tank = new Tank(unitId);
                    this.InsertUnit(tank);
                    break;
                case "Queen":
                    var queen = new Queen(unitId);
                    this.InsertUnit(queen);
                    break;
                case "Parasite":
                    var parasit = new Parasite(unitId);
                    this.InsertUnit(parasit);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }            
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            string supplementId = commandWords[1];
            string id = commandWords[2];

            var unitForAdding = this.GetUnit(id);
            ISupplement supplement = null;
            switch (supplementId)
            {
                case "AggressionCatalyst":
                    supplement =  new AggressionCatalyst();
                    break;
                case "Weapon":
                   supplement =  new Weapon();   
                    break;
                case "PowerCatalyst":
                    supplement = new PowerCatalyst();
                    break;
                case "HealthCatalyst":
                    supplement = new HealthCatalyst();
                    break;
                default:
                    break;
            }

            unitForAdding.AddSupplement(supplement);
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Attack:
                    Unit targetUnit1 = this.GetUnit(interaction.TargetUnit);
                    Unit sourceUnit1 = this.GetUnit(interaction.SourceUnit);
                    if (targetUnit1 is InfestorUnit)
                    {
                        var infestTarget1 = InfestationRequirements.RequiredClassificationToInfest(sourceUnit1.UnitClassification);
                        if (targetUnit1.UnitClassification == infestTarget1)
                        {
                            sourceUnit1.AddSupplement(new InfestationSpores());
                        }
                    }
                 
                    targetUnit1.DecreaseBaseHealth(interaction.SourceUnit.Power);
                    break;
                //case InteractionType.Infest:
                //    Unit targetUnit = this.GetUnit(interaction.TargetUnit);            
                //    Unit sourceUnit = this.GetUnit(interaction.SourceUnit);
                //    var infestTarget = InfestationRequirements.RequiredClassificationToInfest(targetUnit.UnitClassification);
                //    if (sourceUnit.UnitClassification == infestTarget)
                //    {
                //        targetUnit.AddSupplement(new InfestationSpores());
                //    }

                //    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }

        protected override void ExecuteProceedSingleIterationCommand()
        {

            base.ExecuteProceedSingleIterationCommand();
        }
    }
}
