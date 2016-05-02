namespace FurnitureManufacturer.Models.Furnitures
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs, string chairType) 
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
            this.ChairType = chairType;
        }

        public string ChairType { get; set; }

        public int NumberOfLegs { get; }

        public override string ToString()
        {
            return base.ToString() + $", Legs: {this.NumberOfLegs}";
        }
    }
}
