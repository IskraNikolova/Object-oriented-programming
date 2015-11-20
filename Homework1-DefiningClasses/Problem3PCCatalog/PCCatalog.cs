using System;
using System.Collections.Generic;

public class PCCatalog
{
    public static void Main()
    {
        string motherboard = "Motherboard GA-H97M-D3H";
        decimal priceMotherBoard = 610.0m;

        string processor = "Intel® Core™ i7-6500U Processor";
        decimal pricePocessor = 220.0m;

        string graphicsCard = "Video Card: ASUS STRIX-GTX950-DC2OC-2GD5-GAMING";
        string graphicsCardDetails = "Members: 2048MB GDDR5 128 bit";
        decimal priceGraphicsCard = 550.0m;

        Component components = new Component(motherboard, priceMotherBoard);
        Component components2 = new Component(processor, pricePocessor);
        Component components3 = new Component(graphicsCard, priceGraphicsCard, graphicsCardDetails);

        List<Component> listOfCompo = new List<Component>();
        listOfCompo.Add(components);
        listOfCompo.Add(components2);
        listOfCompo.Add(components3);

        string nameComputer = "Apple MacBook 12 Space Gray";
        Computer comp = new Computer(nameComputer, listOfCompo);


        string motherboard2 = "Motherboard (GA-Z97X-UD3H)";
        decimal priceMotherBoard2 = 230.0m;

        string processor2 = "Intel® Core™ i7-6820HK Processor";
        decimal priceProcessor2 = 500.0m;
        
        string detailsProcessor = "(8M Cache, up to 3.60 GHz)";
        string  graphicsCard2Name = "Video Card: XFX Radeon HD 5450";
        decimal priceGraphicsCard2 = 55.0m;
        
        Component componentsSecond = new Component(motherboard2, priceMotherBoard2);
        Component componentsSecond2 = new Component(processor2, priceProcessor2, detailsProcessor);
        Component componentsSecond3 = new Component(graphicsCard2Name, priceGraphicsCard2);

        List<Component> listOfCompo2 = new List<Component>();
        listOfCompo2.Add(componentsSecond);
        listOfCompo2.Add(componentsSecond2);
        listOfCompo2.Add(componentsSecond3);

        string nameComputer2 = "Lenovo";        
        Computer comp2 = new Computer(nameComputer2, listOfCompo2);

        List<Computer> listForSort = new List<Computer> {comp, comp2};
        listForSort.Sort((x, y) => x.Price.CompareTo(y.Price));


        foreach (Computer computer in listForSort)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(computer);
        }
    }
}

