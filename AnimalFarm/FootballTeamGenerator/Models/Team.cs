namespace FootballTeamGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using FootballTeamGenerator.Interfaces;

    public class Team : ITeam
    {
        private string name;

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<IPlayer>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public List<IPlayer> Players { get; }

        public double Rating
        {
            get
            {
                double rate = 0;
                foreach (var player in this.Players)
                {
                    rate += player.CalculateAvarageOfStatus();
                }

                return rate;
            }
        }

        public void AddPlayer(IPlayer player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(IPlayer player)
        {
            this.Players.Remove(player);
        }
    }
}
