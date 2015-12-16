using System;
using Empires.Interfaces;

namespace Empires.IO
{
    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
