namespace Problem2Laptop_Shop
{
    using System;

    public class LaptopShopMain
    {
        public static void Main()
        {
            string model = "Lenovo Yoga 2 Pro";
            string manufacturer = "Lenovo";
            string processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            int ram = 8;
            string graphicsCard = "Intel HD Graphics 4400";
            string hdd = "128GB SSD";
            string screen = "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display";
            Battery battery = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);      
            decimal price = 2259.00m;

            Laptop laptop = new Laptop(model, price);
            Laptop laptopFullInfo = new Laptop(
                model, 
                price, 
                processor, 
                ram, 
                graphicsCard, 
                hdd, 
                screen,
                battery, 
                manufacturer);

            Console.WriteLine(laptopFullInfo + Environment.NewLine);
            Console.WriteLine(laptop);
        }
    }
}