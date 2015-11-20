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

    public Laptop(string model, decimal price, string processor = null, int rAM = 0, string graphicsCard = null, string hDD = null, string screen = null, Battery battery = null, string manufacturer = null)
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

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model can not be empty!");
            }
                this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Manufacturer can not be empty!");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Processor can not be empty!");
            }
            this.processor = value;
        }
    }
    public int RAM
    {
        get { return this.rAM; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("RAM can not be negative or null!");
            }
            this.rAM = value;
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Graphics card can not be empty!");
            }
            this.graphicsCard = value;
        }
    }
    public string HDD
    {
        get { return this.hDD; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("HDD can not be empty!");
            }
            this.hDD = value;
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Screen can not be empty!");
            }
            this.screen = value;
        }
    }

    public Battery Battery { get; set; }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price can not be negative or null!");
            }
            this.price = value;
        }
    }

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
            result = $"model: {this.Model}\nprice: {this.Price}";
        }
        return result;
    }
}

