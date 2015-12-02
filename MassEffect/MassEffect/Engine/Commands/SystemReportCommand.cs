using System;
using System.Linq;
using System.Text;
using MassEffect.Interfaces;

namespace MassEffect.Engine.Commands
{
    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string locationName = commandArgs[1];

            var location = this.GameEngine.Galaxy.GetStarSystemByName(locationName);

            var shipsInSystem = this.GameEngine.Starships
                .Where(st => st.Location == location);

            var intactShips = shipsInSystem
                .Where(s => s.Health > 0)
                .OrderByDescending(h => h.Health)
                .ThenByDescending(sh => sh.Shields);

            StringBuilder output = new StringBuilder();
            output.AppendLine("Intact ships: ");
            output.AppendLine(intactShips.Any() ? string.Join("\n", intactShips) : "N/A");

            var destroidShips = shipsInSystem
                .Where(s => s.Health == 0)
                .OrderBy(d => d.Name);

            output.AppendLine("Destroyed ships: ");
            output.Append(destroidShips.Any() ? string.Join("\n", destroidShips) : "N/A");

            Console.WriteLine(output.ToString().Trim('\n'));
        }
    }
}