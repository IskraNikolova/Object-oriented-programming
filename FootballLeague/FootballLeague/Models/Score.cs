
using System;

namespace FootballLeague.Models
{
    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.HomeTownGoals = homeTeamGoals;
            this.AwayTownGoals = awayTeamGoals;
        }

        public int HomeTownGoals {
            get
            {
                return this.homeTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals can not be a negative");
                }
                this.homeTeamGoals = value;
            }
        }
        public int AwayTownGoals
        {
            get
            {
                return this.awayTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals can not be a negative");
                }
                this.awayTeamGoals = value;
            }
        }
    }
}
