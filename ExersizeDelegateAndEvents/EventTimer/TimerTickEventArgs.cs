namespace EventTimer
{
    public delegate void TimerTickEventHandler(Timer timer, TimerTickEventArgs eventArgs);

    public class TimerTickEventArgs
    {
        public TimerTickEventArgs(int timeRemaining, int currentTime)
        {
            this.TimeRemaining = timeRemaining;
            this.CurrentTime = currentTime;
        }

        public int TimeRemaining { get; set; }

        public int CurrentTime { get; set; }
    }
}