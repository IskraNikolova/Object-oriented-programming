using System.Linq;
using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using System;

    using MassEffect.Interfaces;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public abstract void Execute(string[] commandArgs);


        protected void ValidateAlive(IStarship ship)
        {
            if (ship.Health <= 0)
            {
                throw new ShipException(string.Format(Messages.ShipDestroyed, ship.Name));
            }
        }

        protected void ValidateAreShipInTheSameStarSystem(IStarship attackShip, IStarship targetShip)
        {
            if (attackShip.Location != targetShip.Location)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
        }


        protected IStarship GetStarship(string shipName)
        {
            return this.GameEngine.Starships.FirstOrDefault(n => n.Name == shipName);
        }
    }
}
