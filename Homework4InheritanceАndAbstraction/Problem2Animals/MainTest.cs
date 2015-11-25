using System;
using System.Collections.Generic;
using System.Linq;

public class MainTest
{
    public static void Main()
    {
        Dog sharo = new Dog("Sharo", 8, "male");
        Cat mimi = new Cat("Mimi", 4, "female");
        Frog kvak = new Frog("Kvaki", 3, "male");
        Kitten pisi = new Kitten("Pisi", 3);
        Tomcat tomi = new Tomcat("Tom", 5);

        List<Animal> animals = new List<Animal> {sharo, mimi, kvak, pisi, tomi};

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);           
            animal.ProduceSound();
            Console.WriteLine("_____________________");
        }

        Console.WriteLine("Their average of age is {0} years.", animals.Average(a => a.Age));
        
    }
}

