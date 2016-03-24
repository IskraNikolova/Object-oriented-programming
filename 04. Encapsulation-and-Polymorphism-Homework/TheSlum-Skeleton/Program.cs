using TheSlum.Interfaces;
using TheSlum.UI;

namespace TheSlum
{
    using GameEngine;

    public class Program
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            IInputHandler inputHandler = new ConsoleInputHandler();
            Engine engine = new Engine(renderer, inputHandler);

            engine.Run();
        }
    }
}