namespace ShoppingSpree.Models
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private double money;

        public Person(string name, double money)
        {
           this.Name = name;
           this.Money = money;
           this.Products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            if (product.Price <= this.Money)
            {
                this.Products.Add(product);
                this.Money -= product.Price;

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
                ;
            }
        }
    }
}
