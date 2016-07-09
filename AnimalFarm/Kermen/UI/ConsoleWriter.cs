using System;
using Kermen.Interfaces;

namespace Kermen.UI
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
