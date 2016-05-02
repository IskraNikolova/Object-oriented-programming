namespace RestaurantManager.Models.Recipes
{
    using System;
    using System.Text;
    using RestaurantManager.Interfaces;

    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;

        protected Recipe(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.Unit = unit;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of restaurant is required.");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be positive.");
                }

                this.price = value;
            }
        }

        public virtual int Calories
        {
            get
            {
                return this.calories;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The calories must be positive.");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The quantity per serving must be positive.");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; }

        public virtual int TimeToPrepare {
            get
            {
                return this.timeToPrepare;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The time to prepare  must be positive.");
                }

                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            string unit = this.Unit == MetricUnit.Grams ? "g" : "ml";
            StringBuilder result = new StringBuilder();
            result.AppendLine($"==  {this.Name} == ${this.Price:F2}");
            result.AppendLine($"Per serving: {this.QuantityPerServing} {unit}, {this.Calories} kcal");
            result.Append($"Ready in {this.TimeToPrepare} minutes");

            return result.ToString();
        }
    }
}