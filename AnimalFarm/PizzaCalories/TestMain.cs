using PizzaCalories.Core;
using PizzaCalories.Interfaces;
using PizzaCalories.UI;

namespace PizzaCalories
{
    public class TestMain
    {
        public static void Main()
        {
            IWriter writer = new ConsoleWriter();
            IReader reader = new ConsoleReader();
            Engine engine = new Engine(writer, reader);
            engine.Run();
        }
    }
}
