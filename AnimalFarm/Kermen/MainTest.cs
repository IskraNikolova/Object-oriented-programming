using Kermen.Core;
using Kermen.Interfaces;
using Kermen.UI;

namespace Kermen
{
    public class MainTest
    {
        public static void Main()
        {
            IWriter consoleWriter = new ConsoleWriter();
            IReader consoleReader = new ConsoleReader();
            IEngine engine = new Engine(consoleWriter, consoleReader);
            engine.Run();
        }
    }
}
