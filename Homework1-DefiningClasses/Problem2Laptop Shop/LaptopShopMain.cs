using System;

public class LaptopShopMain
{
    public static void Main()
    {
        string model = "Lenovo Yoga 2 Pro";
        string manufacturer = "Lenovo";
        string processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
        int RAM = 8;
        string graphicsCard = "Intel HD Graphics 4400";
        string HDD = "128GB SSD";
        string screen = "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display";
        Battery battery = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
        decimal price = 2259.00m;

        Laptop laptop = new Laptop(model, price);
        Laptop laptopFullInfo = new Laptop(model, price: price, processor: processor, 
            rAM: RAM, graphicsCard: graphicsCard, hDD: HDD, screen: screen, battery: battery, manufacturer: manufacturer);


        Console.WriteLine();
        Console.WriteLine("**************************");
        Console.WriteLine(laptopFullInfo);
        Console.WriteLine();
        Console.WriteLine("**************************");
        Console.WriteLine(laptop);

        Console.WriteLine();
        Console.WriteLine("EXCEPTION");
        //string manufacturerEmptyTest = String.Empty;
        //Laptop laptopFullInfo2 = new Laptop(model, price: price, processor: processor,
        //  rAM: RAM, graphicsCard: graphicsCard, hDD: HDD, screen: screen, battery: battery, manufacturer: manufacturerEmptyTest);
        //Console.WriteLine(laptopFullInfo2); //throw new ArgumentNullException
    }
}

