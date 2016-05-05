namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get { return base.Price*this.Milliliters; }
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;               
            }

            private set
            {
                Validator.CheckIfNull(
                    value, 
                    string.Format(GlobalErrorMessages.ObjectCannotBeNull, value));

                this.milliliters = value;
            }
        }

        public UsageType Usage { get; }

        public override string Print()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"  * Quantity: {this.Milliliters} ml");
            output.Append($"  * Usage: {this.Usage}");

            return base.Print() + output;
        }
    }
}
