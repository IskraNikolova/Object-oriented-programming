namespace RestaurantManager.Models.Recipes.Drinks
{
    using System;
    using RestaurantManager.Interfaces;

    public class Drink : Recipe, IDrink
    {
        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, MetricUnit.Milliliters, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
        }

        public override int Calories
        {
            get
            {
                return base.Calories;
            }

            protected set
            {
                if (value > 100)
                {
                    throw new ArgumentException("The calories in a drink must not be greater than 100.");
                }

                base.Calories = value;
            }
        }

        public override int TimeToPrepare
        {
            get
            {
                return base.TimeToPrepare;
            }

            protected set
            {
                if (value > 20)
                {
                    throw new ArgumentException("The time to prepare a drink must not be greater than 20 minutes.");
                }

                base.TimeToPrepare = value;
            }
        }

        public bool IsCarbonated { get; }

        public override string ToString()
        {
            string yesOrNo = this.IsCarbonated ? "yes" : "no";

            return base.ToString() + $"\nCarbonated: {yesOrNo}";
        }
    }
}
