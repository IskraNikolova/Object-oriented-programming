using System;

public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int rAM;
    private string graphicsCard;
    private string hDD;
    private string screen;
    private Battery battery;
    private decimal price;

    public Laptop(string model, string manufacturer, Battery battery, decimal price = 0.0m, string processor = null, int rAM = 0, 
        string graphicsCard = null, string hDD = null, string screen = null)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = rAM;
        this.GraphicsCard = graphicsCard;
        this.HDD = hDD;
        this.Screen = screen;
        this.Battery = new Battery(battery.Batt, battery.BatteryLife);
        this.Price = price;

    }

    public Laptop(string model, string manufacturer1)
    {
        this.Model = model;
        this.Manufacturer = manufacturer1;
    }

    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public string Processor { get; set; }
    public int RAM { get; set; }
    public string GraphicsCard { get; set; }
    public string HDD { get; set; }
    public string Screen { get; set; }
    public Battery Battery { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
       string result = String.Empty;
        if (this.Battery != null && this.Processor != null && this.RAM != 0)
        {
            result = $"model: {this.Model}\nmanufacturer: {this.Manufacturer}\nprocessor: " +
            $"{this.Processor}\nRAM: {this.RAM} GB\ngraphics card: {this.GraphicsCard}\nHDD: {this.HDD}\nscreen: {this.Screen}\n" +
            $"battery: {Battery.Batt}\nbattery life: {Battery.BatteryLife} hours\nprice: {this.Price:F2} lv";
        }
        else
        {
            result = $"model: {this.Model}\nmanufacturer: {this.Manufacturer}";
        }
        return result;
    }
}

