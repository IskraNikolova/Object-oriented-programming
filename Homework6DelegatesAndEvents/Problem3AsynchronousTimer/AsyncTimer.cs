
    using System;
    using System.Threading;

public class AsyncTimer
{
    private int ticks;
    private int interval;
    private string message;

    public AsyncTimer(Action<string> action, int ticks, int interval, string message)
    {
        this.Action = action;
        this.Ticks = ticks;
        this.Interval = interval;
        this.Message = message;
    }

    public Action<string> Action { get; set; }

    public int Ticks
    {
        get { return this.ticks; }

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

    public string Message
    {
        get { return this.message; }

        set
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException("Message cannot be null or empty.");
            }

            this.message = value;
        }
    }

    public void Run()
    {
        var tick = new Thread(this.Execute);
        tick.Start();
    }

    private void Execute()
    {
        for (int i = 0; i < this.ticks; i++)
        {
            Thread.Sleep(this.Interval);
            Console.WriteLine(this.Message);
        }
    }
}

