namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Foods;
    using WildFarm.Models;

    public class Engine
    {
        private readonly AnimalFactory factory;
        private readonly List<Animal> animals; 
        private readonly List<Food> foods; 

        public Engine()
        {
            this.factory = new AnimalFactory();
            this.animals = new List<Animal>();
            this.foods = new List<Food>();
        }

        public void Run()
        {
            string inputLine = Console.ReadLine();
            int count = 0;
            while (inputLine != "End")
            {
                if (count % 2 == 0)
                {
                    Animal animal = factory.CreateAnimal(inputLine);
                    this.animals.Add(animal);
                }
                else
                {
                    string[] args = inputLine.Split();
                    string typeOfFood = args[0];
                    int quantity = int.Parse(args[1]);
                    Food food = null;
                    if (typeOfFood == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                    }
                    else
                    {
                        food = new Meat(quantity);
                    }

                    this.foods.Add(food);
                }

                count++;
                inputLine = Console.ReadLine();
            }


            for(int i = 0; i < this.animals.Count; i++)
            {
                this.animals[i].MakeSound();
                this.animals[i].Eat(this.foods[i]);
                Console.WriteLine(this.animals[i]);
            }
        }
    }
}
