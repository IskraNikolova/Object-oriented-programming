using System;
using System.Collections.Generic;
using System.Linq;

//Create an abstract class Animal holding name, age and gender.
//Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat.Dogs, frogs and cats are animals.
//Kittens are female cats and Tomcats are male cats.Define useful constructors and methods.
//Define an interface ISoundProducible which holds the method ProduceSound(). All animals should implement this interface. 
//The ProduceSound() method should produce a specific sound depending on the animal invoking it(e.g.the dog should bark).
//Create an array of different kinds of animals and calculate the average age of each kind of animal using LINQ.

public class MainTest
{
    public static void Main()
    {
        Dog sharo = new Dog("Sharo", 2, "male");
        Dog bayf = new Dog("Bauf", 3, "male");
        Cat mimi = new Cat("Mimi", 4, "female");
        Cat nini = new Cat("Nini", 7, "female");
        Frog kvak = new Frog("Kvak", 3, "male");
        Frog kvaki = new Frog("Kvaki", 1, "male");
        Frog kvako = new Frog("Kvako", 7, "male");
        Kitten pisi = new Kitten("Pisi", 3);
        Tomcat tomi = new Tomcat("Tomi", 5);
        Tomcat tom = new Tomcat("Tom", 5);
        Tomcat tomcho = new Tomcat("Tomcho", 5);

        List<Animal> animals = new List<Animal> {sharo, bayf, mimi, nini, kvak, kvaki, kvako, pisi, tomi, tom, tomcho};

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);           
            animal.ProduceSound();
            Console.WriteLine("_____________________");
        }

        Console.WriteLine("Avarage of dog's years is {0:F2}\n" +
                          "Avarage of cat's years is {1:F2}\n" +
                          "Avarage of frog's years is {2:F2}\n"+
                          "Avarage of kitten's years is {3:F2}\n"+
                          "Avarage of tomcat's years is {4:F2}\n",
                          animals.Where(a => a.GetType().Name == "Dog").Average(d => d.Age),
                          animals.Where(a => a.GetType().Name == "Cat").Average(d => d.Age), 
                          animals.Where(a => a.GetType().Name == "Frog").Average(d => d.Age),
                          animals.Where(a => a.GetType().Name == "Kitten").Average(d => d.Age),
                          animals.Where(a => a.GetType().Name == "Tomcat").Average(d => d.Age));
        
    }
}

