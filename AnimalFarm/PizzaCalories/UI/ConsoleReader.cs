namespace PizzaCalories.UI
{
    using System;
    using PizzaCalories.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
