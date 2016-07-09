namespace FootballTeamGenerator.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FootballTeamGenerator.Interfaces;

    public class Command : ICommand
    {
        public List<string> ProcessCommand(string input)
        {
            List<string> args = input
                .Trim()
                .Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            return args;
        }
    }
}
