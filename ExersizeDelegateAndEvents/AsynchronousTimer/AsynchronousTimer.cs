namespace AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsynchronousTimer
    {
        public event EventHandler OnRun;

        public AsynchronousTimer(Action<object, EventArgs> action, int tick, int tickInterval)
        {
            this.Tick = tick;
            this.TickInterval = tickInterval;
            this.Action = action;
        }

        public Action<object, EventArgs> Action { get; set; }

        public int Tick { get; set; }
        public int TickInterval { get; set; }

        public void Run()
        {
            for (int i = 0; i < this.Tick; i++)
            {
                Thread.Sleep(this.TickInterval);

                if (this.OnRun != null)
                {
                    this.OnRun(this, EventArgs.Empty);
                }
            }
        }
    }
}