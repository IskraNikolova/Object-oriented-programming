using System;
using System.Linq;
using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            IStarship ship = this.GameEngine.Starships.FirstOrDefault(n => n.Name == shipName);

            if (ship == null)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
            Console.WriteLine(ship.ToString());
        }
    }
}
