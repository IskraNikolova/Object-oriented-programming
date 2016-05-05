namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const int MinLength = 2;
        private const int MaxLength = 15;

        private string name;

        public Category(string name)
        {
            this.Name = name;
            this.Products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
                
            }

            private set
            {
                string message = string.Format(
                    GlobalErrorMessages.InvalidStringLength, 
                    "Category name",
                    MinLength,
                    MaxLength);

                Validator.CheckIfStringLengthIsValid(value, MaxLength, MinLength, message);

                this.name = value;
            }
        }

        public IList<IProduct> Products { get; }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.Products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.Products.Contains(cosmetics))
            {
                Console.WriteLine($"Product {cosmetics.Name} does not exist in category {this.Name}!");
            }

            this.Products.Remove(cosmetics);
        }

        public string Print()
        {
            string sOrNo = this.Products.Count != 1 ? "products" : "product";
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} category - {this.Products.Count} {sOrNo} in total");

            var orderedProduct = this.Products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            foreach (var product in orderedProduct)
            {
                sb.Append(product.Print());
            }

            return sb.ToString();
        }
    }
}
