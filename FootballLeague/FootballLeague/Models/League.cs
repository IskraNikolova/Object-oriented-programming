using System;
using System.Collections.Generic;
using System.Linq;


namespace FootballLeague.Models
{
    public static class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(Team team)
        {
            
            if (CheckIfTeamExists(team))
            {
                throw new InvalidOperationException("Team already exists");
            }
            teams.Add(team);
        }

        private static bool CheckIfTeamExists(Team team)
        {
            return teams.Any(p => p.Name == team.Name);
        }


        public static void AddMatch(Match match)
        {
            if (CheckIfMatchExists(match))
            {
                throw new InvalidOperationException("Team already exists");
            }
            matches.Add(match);
        }

        private static bool CheckIfMatchExists(Match match)
        {
            return matches.Any(p => p.ID == match.ID);
        }
    }
}
