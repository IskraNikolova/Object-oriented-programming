namespace AsynchronousTimer
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Action<object, EventArgs> getTime = GetTime;

            var timer = new AsynchronousTimer(getTime, 10, 1000);
            timer.OnRun += GetTime;
            timer.Run();
        }

        public static void GetTime(object sender, EventArgs eventArgs)
        {
            var timeNow = DateTime.Now;
            Console.WriteLine("{0}", timeNow.ToString("HH:mm:ss"));
        }
    }
}