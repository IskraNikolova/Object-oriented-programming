namespace LambdaCore_Skeleton.UI
{
    using System;
    using Interfaces;
    public class ConsoleWriter : IWritter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
