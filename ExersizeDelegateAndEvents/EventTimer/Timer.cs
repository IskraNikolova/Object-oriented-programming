using System;
using System.Threading;

namespace EventTimer
{
    public class Timer
    {
        public event TimerTickEventHandler OnTick;

        private int seconds;
        private int interval;

        public Timer(int seconds, int interval)
        {
            this.seconds = seconds;
            this.interval = interval;
        }

        public void Run()
        {
            while (seconds > 0)
            {
                Thread.Sleep(this.interval);
                if (this.OnTick != null)
                {
                    this.OnTick(this, new TimerTickEventArgs(this.seconds, this.interval));
                }

                seconds -= this.interval;
            }
        }
    }
}
