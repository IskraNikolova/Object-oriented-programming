using System.Collections.Generic;

namespace FootballTeamGenerator.Interfaces
{
    public interface ICommand
    {
        List<string> ProcessCommand(string input);
    }
}