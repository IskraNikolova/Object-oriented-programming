using BookStore.Interfaces;
using BookStore.UI;

namespace BookStore
{
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        { 
            IInputHandler input = new ConsoleInputHandler();
            IRenderer renderer = new ConsoleRenderer();

            BookStoreEngine engine = new BookStoreEngine(input, renderer);

            engine.Run();
        }
    }
}