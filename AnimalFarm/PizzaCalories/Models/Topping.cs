namespace PizzaCalories.Models
{
    using System;
    using PizzaCalories.Enums;

    public class Topping
    {
        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            this.ToppingType = type;
            this.Grams = grams;
        }

        public string ToppingType
        {
            get
            {
                return this.type;
            }

            set
            {
                if (!Enum.IsDefined(typeof(ToppingType), value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }
        public double Grams
        {
            get
            {
                return this.grams;
            }

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }

                this.grams = value;
            }
        }
    }
}
