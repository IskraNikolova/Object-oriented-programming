
using System;

public class Battery
{
    private string battery;
    private double batteryLife;

    public Battery(string battery, double batteryLife)
    {
        this.Batt = battery;
        this.BatteryLife = batteryLife;
    }

    public string Batt
    {
        get { return this.battery; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Battery can not be empty!");
            }
            this.battery = value;
        }
    }
    public double BatteryLife
    {
        get { return this.batteryLife; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Battery life can not be negative or null!");
            }
            this.batteryLife = value;
        }
    }
}

