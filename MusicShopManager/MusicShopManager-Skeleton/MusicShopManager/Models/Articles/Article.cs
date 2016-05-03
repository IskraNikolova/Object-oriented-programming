using System;
using System.Text;
using MusicShop.Interfaces;

namespace MusicShop.Models.Articles
{
    public abstract class Article : IArticle
    {
        private string make;
        private string model;
        private decimal price;

        protected Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }   

        public string Make {
            get
            {
                return this.make;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The make is required");
                }

                this.make = value;
            }
        }

        public string Model {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model is required");
                }

                this.model = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("The price must be positive.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"= {this.Make} {this.Model} =");
            output.Append($"Price: ${this.Price:F2}");
            return output.ToString();
        }
    }
}
