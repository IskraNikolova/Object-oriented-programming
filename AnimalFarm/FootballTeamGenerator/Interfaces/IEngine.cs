namespace FootballTeamGenerator.Interfaces
{
    public interface IEngine
    {
        IWriter Writer { get; }

        IReader Reader { get; }

        void Run();
    }
}