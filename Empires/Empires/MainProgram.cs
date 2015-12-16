
using Empires.Core;
using Empires.Factories;
using Empires.IO;

namespace Empires
{
    public class MainProgram
    {
        public static void Main()
        {
            var buldingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new EmpiresDate();

            var engine = new Engine(buldingFactory, resourceFactory, unitFactory, data, reader, writer);
            engine.Run();

        }
    }
}
