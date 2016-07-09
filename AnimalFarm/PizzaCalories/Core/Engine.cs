using System;
using PizzaCalories.Interfaces;
using PizzaCalories.Models;

namespace PizzaCalories.Core
{
    public class Engine
    {
        private readonly PizzaFactory pizzaFactory;
        private readonly DoughFactory doughFactory;
        private readonly ToppingFactory toppingFactory;
        private IWriter writer;
        private IReader reader;

        public Engine(IWriter writer, IReader reader)
        {
            this.pizzaFactory = new PizzaFactory();
            this.doughFactory = new DoughFactory();
            this.toppingFactory = new ToppingFactory();
            this.writer = writer;
            this.reader = reader;
        }

        public void Run()
        {
            try
            {
                string input = this.reader.ReadLine();
                while (input != "END")
                {   
                    string[] data = input.Split();
                    if (data[0] == "Dough")
                    {
                        Dough doughCreate = this.doughFactory.CreateDough(input);
                        this.writer.WriteLine($"{CalculateDoughCalories.CalculateDoughCaloriesMethod(doughCreate):F2}");
                    }
                    else if (data[0] == "Topping")
                    {
                        Topping toppinCreate = this.toppingFactory.CreateTopping(input);
                        this.writer.WriteLine(
                            $"{CalculateCaloriesOfTopping.CalculateToppingCalories(toppinCreate):F2}");
                    }
                    else if (data[0] == "Pizza")
                    {
                        string pizzaName = data[1].Trim();
                        int numberOfToppings = int.Parse(data[2].Trim());
                        Pizza pizza = this.pizzaFactory.CreatePizza(pizzaName, numberOfToppings);

                        string inputForDough = this.reader.ReadLine();
                        Dough dough = this.doughFactory.CreateDough(inputForDough);
                        pizza.Dough = dough;

                        for (int i = 0; i < numberOfToppings; i++)
                        {
                            string inputForTopping = this.reader.ReadLine();

                            Topping topping = this.toppingFactory.CreateTopping(inputForTopping);
                            pizza.AddTopping(topping);
                        }

                        this.writer.WriteLine($"{pizza.Name} - {pizza.TottalCalories:F2} Calories.");
                    }

                    input = this.reader.ReadLine();                   
                }            
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
