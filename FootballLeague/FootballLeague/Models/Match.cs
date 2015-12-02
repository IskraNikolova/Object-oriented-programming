
namespace FootballLeague.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.ID = id;
        }

        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public Score Score { get; set; }
        public int ID { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTownGoals > this.Score.AwayTownGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTownGoals == this.Score.HomeTownGoals;
        }

        public override string ToString()
        {
            return this.id + " " + this.HomeTeam.Name + " vs. " + this.AwayTeam.Name + " " + this.Score.HomeTownGoals + ":" + this.Score.AwayTownGoals;
        }
    }
}
