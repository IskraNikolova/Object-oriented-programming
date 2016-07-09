using System.Collections.Generic;

namespace FootballTeamGenerator.Interfaces
{
    public interface ITeam
    {
        List<IPlayer> Players { get; }

        string Name { get; }

        double Rating { get; }

        void AddPlayer(IPlayer player);

        void RemovePlayer(IPlayer player);
    }
}