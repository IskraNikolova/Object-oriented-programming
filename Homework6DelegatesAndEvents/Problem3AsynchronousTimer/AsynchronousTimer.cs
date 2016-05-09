namespace Problem3AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsynchronousTimer
    {
        public event EventHandler OnTick;

        private int ticks;
        private int interval;

        public AsynchronousTimer(Action<object, EventArgs> action, int ticks, int interval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public Action<object, EventArgs> Action { get; set; }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be negative");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get { return this.interval; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be negative");
                }

                this.interval = value;
            }
        }

        public void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.Interval);
                if (this.OnTick != null)
                {
                    this.OnTick(this, EventArgs.Empty);
                }
            }       
        }
    }
}