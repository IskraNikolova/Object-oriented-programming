namespace TheSlum.UI
{
    using System;
    using TheSlum.Interfaces;

    public class ConsoleInputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}