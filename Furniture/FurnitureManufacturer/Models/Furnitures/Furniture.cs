namespace FurnitureManufacturer.Models.Furnitures
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        protected Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Model cannot be empty, null");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be with less than 3 symbols.");
                }

                this.model = value;
            }
        }

        public string Material { get; }

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
                    throw new ArgumentNullException(nameof(value), "Price cannot be less or equal to $0.00.");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException(nameof(value), "Height cannot be less or equal to 0.00 m");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Model: {this.Model}, Material: {this.Material}, Price: {this.Price}, Height: {this.Height}";
        }
    }
}
