using System;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            var attackerShip = GetStarship(attackerName);
            var targetShip = GetStarship(targetName);

            this.ProcessStarShipBattle(attackerShip, targetShip);
        }

        private void ProcessStarShipBattle(IStarship attackerShip, IStarship targetShip)
        {
            base.ValidateAlive(attackerShip);
            base.ValidateAlive(targetShip);

            base.ValidateAreShipInTheSameStarSystem(attackerShip, targetShip);

            var attack = attackerShip.ProduceAttack();
            targetShip.RespondToAttack(attack);

            Console.WriteLine(Messages.ShipAttacked, attackerShip.Name, targetShip.Name);

            if (targetShip.Shields < 0)
            {
                targetShip.Shields = 0;
            }

            if (targetShip.Health < 0)
            {
                targetShip.Health = 0;
                Console.WriteLine(Messages.ShipDestroyed, targetShip.Name);
            }
        }
    }
}
