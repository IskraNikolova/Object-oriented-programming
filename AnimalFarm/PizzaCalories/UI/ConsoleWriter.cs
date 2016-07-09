namespace PizzaCalories.UI
{
    using System;
    using PizzaCalories.Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string data)
        {
            Console.WriteLine(data);
        }
    }
}
