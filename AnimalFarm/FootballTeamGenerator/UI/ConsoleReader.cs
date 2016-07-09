namespace FootballTeamGenerator.UI
{
    using System;
    using FootballTeamGenerator.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
