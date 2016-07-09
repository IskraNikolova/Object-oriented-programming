namespace FootballTeamGenerator.UI
{
    using System;
    using FootballTeamGenerator.Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
