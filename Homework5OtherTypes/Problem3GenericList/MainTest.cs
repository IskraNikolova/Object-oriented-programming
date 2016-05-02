namespace Problem3GenericList
{
    using System;

    public class MainTest
    {
        public static void Main()
        {   
            GenericList<int> numbers = new GenericList<int>();
            var version = numbers.Version();
            Console.WriteLine(version);
        }
    }
}