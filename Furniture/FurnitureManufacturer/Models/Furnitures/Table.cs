namespace FurnitureManufacturer.Models.Furnitures
{
    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, ITable
    {
        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; }

        public decimal Width { get; }

        public decimal Area
        {
            get
            {
                return this.Length*this.Width;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Length: {this.Length}, Width: {this.Width}, Area: {this.Area}";
        }
    }
}
