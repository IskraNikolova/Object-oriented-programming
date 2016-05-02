using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs, string chairType) 
            : base(model, material, price, height, numberOfLegs, chairType)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
