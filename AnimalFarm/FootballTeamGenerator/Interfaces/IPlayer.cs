namespace FootballTeamGenerator.Interfaces
{
    public interface IPlayer
    {
        string Name { get; } 

        double Endurance { get; }

        double Sprint { get; }

        double Dribble { get; }

        double Passing { get; }

        double Shooting { get; }

        double CalculateAvarageOfStatus();
    }
}