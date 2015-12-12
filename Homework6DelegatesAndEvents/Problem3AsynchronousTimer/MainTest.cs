using System;

namespace Problem3AsynchronousTimer
{
    public class MainTest
    {
        public static void Main()
        {
            var asyncTimer = new AsyncTimer(Console.WriteLine, 13, 500, "Some message");
            
            asyncTimer.Run();
        }
    }
}
