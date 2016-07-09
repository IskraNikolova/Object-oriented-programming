using System;
using System.Security.AccessControl;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
