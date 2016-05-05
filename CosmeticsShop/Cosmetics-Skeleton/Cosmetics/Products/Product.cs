namespace Cosmetics.Products
{
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private const int MinLength = 2;
        private const int MaxLength = 10;

        private string name;
        private string brand;
        private decimal price;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
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
                    "Product name",
                    3,
                    MaxLength);

                Validator.CheckIfStringLengthIsValid(value, MaxLength, 3, message);

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
                
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(
                    value, 
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));

                string message = string.Format(
                  GlobalErrorMessages.InvalidStringLength,
                  "Product brand",
                  MinLength,
                  MaxLength);

                Validator.CheckIfStringLengthIsValid(value, MaxLength, MinLength, message);

                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
                
            }

            private set
            {
                Validator.CheckIfNull(
                    value, 
                    string.Format(GlobalErrorMessages.ObjectCannotBeNull, value));

                this.price = value;
            }
        }

        public GenderType Gender { get; }

        public virtual string Print()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"\n- {this.Brand} - {this.Name}:");
            output.AppendLine($"  * Price: ${this.Price}");
            output.AppendLine($"  * For gender: {this.Gender}");

            return output.ToString();
        }
    }
}
