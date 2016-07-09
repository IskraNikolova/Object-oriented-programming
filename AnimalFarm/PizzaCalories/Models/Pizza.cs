using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private int numberOfToppings;
        private readonly List<Topping> toppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.Dough = Dough;
            this.NumberOfToppings = numberOfToppings;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 15 && String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings
        {
            get
            {
                return this.numberOfToppings;
            }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public Dough Dough { get; set; }

        public double TottalCalories
        {
            get
            {
                double doughtCalories = 
                    CalculateDoughCalories.CalculateDoughCaloriesMethod(this.Dough);

                double allCaloriesOfToppings = 0;
                foreach (var topping in this.toppings)
                {
                    allCaloriesOfToppings += 
                        CalculateCaloriesOfTopping.CalculateToppingCalories(topping);
                }

                return doughtCalories + allCaloriesOfToppings;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }
    }
}
