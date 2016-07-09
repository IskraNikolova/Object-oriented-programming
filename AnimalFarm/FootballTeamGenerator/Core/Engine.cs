namespace FootballTeamGenerator.Core
{
    using System;
    using FootballTeamGenerator.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine : IEngine
    {
        private readonly List<ITeam> teams;
        private readonly IFactory factory;
        private readonly PlayerFactory palyerFactory;
        public Engine(IReader reader, IWriter writer)
        {
            this.Reader = reader;
            this.Writer = writer;
            this.Command = new Command();
            this.teams = new List<ITeam>();
            this.factory = new TeamFactory();
            this.palyerFactory = new PlayerFactory();
        }

        public IWriter Writer { get; }

        public IReader Reader { get; }

        public ICommand Command { get; }

        public void Run()
        {
   
        string input = this.Reader.ReadLine();
        while (input != "END")
        {
            try
            {
                var args = this.Command.ProcessCommand(input);
                string commandName = args[0].ToLower();
                switch (commandName)
                {
                    case "team":
                        ITeam team = this.factory.CreateTeam(args);
                        this.teams.Add(team);
                        break;
                    case "add":
                        string teamName = args[1];
                        IPlayer player = this.palyerFactory.CreatePlayer(args);
                        try
                        {
                            this.teams.First(t => t.Name == teamName).AddPlayer(player);
                        }
                        catch (Exception)
                        {
                            this.Writer.WriteLine($"Team {teamName} does not exist.");
                        }
               
                        break;
                    case "remove":
                        string name = args[1];
                        string playerName = args[2];
                        IPlayer playerForRemove = this.teams.FirstOrDefault(t => t.Name == name)
                            .Players.FirstOrDefault(p => p.Name == playerName);
                        if (playerForRemove != null)
                        {
                            this.teams.FirstOrDefault(t => t.Name == name).RemovePlayer(playerForRemove);
                        }
                        else
                        {
                            this.Writer.WriteLine($"Player {playerName} is not in {name} team.");
                        }
                        break;
                    case "rating":
                        string nameOfTeam = args[1];
                        try
                        {
                            var teamR = this.teams.FirstOrDefault(t => t.Name == nameOfTeam);
                            this.Writer.WriteLine($"{nameOfTeam} - {Math.Ceiling(teamR.Rating)}");
                        }
                        catch (Exception)
                        {
                            this.Writer.WriteLine($"Team {nameOfTeam} does not exist.");
                        }
               
                        break;
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

             input = this.Reader.ReadLine();
            }    
        }
    }
}
