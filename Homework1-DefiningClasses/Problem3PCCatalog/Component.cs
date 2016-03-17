namespace Problem3PCCatalog
{
    using System;

    public class Component
    {
        private string name;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price)
            : this(name, null, price)
        {
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
                    throw new ArgumentException("Name can not be null.");
                }

                this.name = value;
            }
        }

        public string Details { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be negative or null!");
                }

                this.price = value;
            }
        }
    }
}