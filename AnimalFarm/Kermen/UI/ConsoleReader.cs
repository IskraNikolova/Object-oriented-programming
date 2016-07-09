namespace Kermen.UI
{
    using System;
    using Kermen.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
