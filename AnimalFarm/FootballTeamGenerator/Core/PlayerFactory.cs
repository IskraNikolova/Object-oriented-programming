using System.Collections.Generic;

namespace FootballTeamGenerator.Core
{
    using FootballTeamGenerator.Interfaces;
    using FootballTeamGenerator.Models;

    public class PlayerFactory
    {
        public IPlayer CreatePlayer(List<string> data)
        {
            string playerName = data[2];
            double endurance = double.Parse(data[3]);
            double sprint = double.Parse(data[4]);
            double dribble = double.Parse(data[5]);
            double passing = double.Parse(data[6]);
            double shooting = double.Parse(data[7]);

            return new Player(playerName,
                endurance,
                sprint,
                dribble,
                passing,
                shooting);
        }
    }
}

