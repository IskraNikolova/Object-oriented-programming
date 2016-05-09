namespace EventTimer
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Timer timer = new Timer(5000, 1000);
            timer.OnTick += Timer_OnTick;
            timer.Run();
        }

        private static void Timer_OnTick(object sender, TimerTickEventArgs e)
        {
            Console.WriteLine("Timer ticked!");
            Console.WriteLine("Time seconds - {0}", e.TimeRemaining);
        }
    }
}