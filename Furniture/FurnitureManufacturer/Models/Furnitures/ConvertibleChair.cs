namespace FurnitureManufacturer.Models.Furnitures
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs, string chairType) 
            : base(model, material, price, height, numberOfLegs, chairType)
        {
            this.IsConverted = false;
            if (!IsConverted)
            {
                this.State = StateOfConvertableChair.Normal;
            }
            else
            {
                this.State = StateOfConvertableChair.Converted;
                base.Height = 0.10m;
            }
        }

        public StateOfConvertableChair State { get; private set; }

        public bool IsConverted { get; private set; }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            return base.ToString() + $", State: {this.State}";
        }
    }
}
