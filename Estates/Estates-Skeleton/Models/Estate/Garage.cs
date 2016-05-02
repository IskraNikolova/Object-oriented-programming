namespace Estates.Models.Estate
{
    using Estates.Interfaces;

    public class Garage : Estate, IGarage
    {
        public Garage()
            : base()
        {
            this.Width = Width;
            this.Height = Height;
            this.Type = EstateType.Garage;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Width: {this.Width}, Height: {this.Height}";
        }
    }
}