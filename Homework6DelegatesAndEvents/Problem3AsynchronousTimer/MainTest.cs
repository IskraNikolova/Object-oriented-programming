namespace Problem3AsynchronousTimer
{
    using System;

    public class MainTest
    {
        public static void Main()
        {
            Action<object, EventArgs> action = GetTime;

            var asyncTimer = new AsynchronousTimer(action, 10, 1000);
            asyncTimer.OnTick += GetTime;
            asyncTimer.Run();

        }

        public static void GetTime(object sender, EventArgs args)
        {
            var dateTimeNow = DateTime.Now;
            Console.WriteLine($"{dateTimeNow.ToString("HH:mm:ss")}");
        }
    }
}