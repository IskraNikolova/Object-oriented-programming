using FootballTeamGenerator.Core;
using FootballTeamGenerator.Interfaces;
using FootballTeamGenerator.UI;

namespace FootballTeamGenerator
{
    public class MainTest
    {
        public static void Main()
        {           
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
