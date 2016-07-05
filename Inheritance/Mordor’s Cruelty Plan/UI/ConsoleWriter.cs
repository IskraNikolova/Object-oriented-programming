namespace Mordor_s_Cruelty_Plan.UI
{
    using System;
    using Mordor_s_Cruelty_Plan.Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
