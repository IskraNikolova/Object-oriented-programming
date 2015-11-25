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

        List<Animal> animals = new List<Animal>();
        animals.Add(sharo);
        animals.Add(mimi);
        animals.Add(kvak);
        animals.Add(pisi);
        animals.Add(tomi);

        Console.WriteLine("Average: {0}", animals.Average(a => a.Age));        
    }
}

