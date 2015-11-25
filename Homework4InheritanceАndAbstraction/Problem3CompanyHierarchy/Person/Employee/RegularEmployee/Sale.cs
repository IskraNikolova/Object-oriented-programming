
using System;

namespace Problem3CompanyHierarchy.Person.Employee
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be empty!");
                }
                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"\nProduct name of sale: {this.ProductName} {this.Date} {this.Price}lv.";
        }
    }
}
