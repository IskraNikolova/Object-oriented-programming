namespace TheSlum.UI
{
    using System;
    using TheSlum.Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}