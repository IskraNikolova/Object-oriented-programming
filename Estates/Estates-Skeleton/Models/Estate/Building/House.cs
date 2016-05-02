namespace Estates.Models.Estate.Building
{
    using Estates.Interfaces;

    public class House : Building, IHouse
    {
        public House() 
            : base()
        {
            this.Floors = Floors;
            this.Type = EstateType.House;
        }

        public int Floors { get; set; }

        public override string ToString()
        {
            string isFurnitured = this.IsFurnished ? "Yes" : "No";
            return $"" +
                   $"House: Name = {this.Name}, " +
                   $"Area = {this.Area}, " +
                   $"Location = {this.Location}, " +
                   $"Furnitured = {isFurnitured}, " +
                   $"Floors: {this.Floors}";
        }
    }
}
