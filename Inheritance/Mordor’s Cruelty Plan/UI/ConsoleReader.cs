using System;
using Mordor_s_Cruelty_Plan.Interfaces;

namespace Mordor_s_Cruelty_Plan.UI
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
