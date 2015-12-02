
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FootballLeague.Models
{
    public class Team
    {
        private const int validationsYear = 1850;
        private string name;
        private string nickName;
        private DateTime dateFounded;
        private readonly List<Player> player;

        public Team(string name, string nickName, DateTime dateFounded)
        {
            this.Name = name;
            this.NickName = nickName;
            this.DateFound = dateFounded;
            this.player = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new FormatException("Name must be least at 5 symbols");
                }
                this.name = value;
            }
        }

        public string NickName
        {
            get { return this.nickName; }
            set
            {
                if (value.Length < 5)
                {
                    throw new FormatException("Nickname must be least at 5 symbols");
                }
                this.nickName = value;
            }
        }

        public DateTime DateFound {
            get
            {
                return this.dateFounded;
            }
            set
            {
                if (value.Year < 1850)
                {
                    throw new ArgumentException($"Year cannot be before {validationsYear}");
                }
            }
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return this.player;
            }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team");
            }
            this.player.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.player.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            return this.Name + " - " + string.Join(", ", player.Select(p => p.ToString()));
        }
    }
}
