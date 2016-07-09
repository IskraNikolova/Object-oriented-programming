namespace FootballTeamGenerator.Core
{
    using FootballTeamGenerator.Interfaces;
    using System.Collections.Generic;
    using FootballTeamGenerator.Models;

    public class TeamFactory : IFactory
    {
        public ITeam CreateTeam(List<string> data)
        {
            string name = data[1];

            return new Team(name);
        }
    }
}
