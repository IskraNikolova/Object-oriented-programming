using System.Collections.Generic;

namespace FootballTeamGenerator.Interfaces
{
    public interface IFactory
    {
        ITeam CreateTeam(List<string> data);
    }
}