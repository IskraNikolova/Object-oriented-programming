//Create an abstract class Animal holding name, age and gender.
//Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat.Dogs, frogs and cats are animals.
//Kittens are female cats and Tomcats are male cats.Define useful constructors and methods.
//Define an interface ISoundProducible which holds the method ProduceSound(). All animals should implement this interface. 
//The ProduceSound() method should produce a specific sound depending on the animal invoking it(e.g.the dog should bark).
//Create an array of different kinds of animals and calculate the average age of each kind of animal using LINQ.

namespace Problem2Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Problem2Animals.Animal;
    using Problem2Animals.Animal.Cat;

    public class MainTest
    {
        public static void Main()
        {
            List<Animal.Animal> animals = new List<Animal.Animal>
            {
                new Dog("Sharo", 2, "male"),
                new Dog("Bauf", 3, "male"),
                new Cat("Mimi", 4, "female"),
                new Cat("Nini", 7, "female"),
                new Frog("Kvak", 3, "male"),
                new Frog("Kvaki", 1, "male"),
                new Frog("Kvako", 7, "male"),
                new Kitten("Pisi", 3),
                new Tomcat("Tomi", 5),
                new Tomcat("Tom", 5),
                new Tomcat("Tomcho", 5)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
                Console.WriteLine("_____________________");
            }

            Console.WriteLine("Avarage of dog's years is {0:F2}\n" +
                              "Avarage of cat's years is {1:F2}\n" +
                              "Avarage of frog's years is {2:F2}\n" +
                              "Avarage of kitten's years is {3:F2}\n" +
                              "Avarage of tomcat's years is {4:F2}\n",
                animals.Where(a => a.GetType().Name == "Dog").Average(d => d.Age),
                animals.Where(a => a.GetType().Name == "Cat").Average(d => d.Age),
                animals.Where(a => a.GetType().Name == "Frog").Average(d => d.Age),
                animals.Where(a => a.GetType().Name == "Kitten").Average(d => d.Age),
                animals.Where(a => a.GetType().Name == "Tomcat").Average(d => d.Age));

        }
    }
}