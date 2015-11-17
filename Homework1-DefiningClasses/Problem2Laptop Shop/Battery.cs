
public class Battery
{
    private string battery;
    private double batteryLife;

    public Battery(string battery, double batteryLife)
    {
        this.Batt = battery;
        this.BatteryLife = batteryLife;
    }

    public string Batt { get; set; }
    public double BatteryLife { get; set; }
}

