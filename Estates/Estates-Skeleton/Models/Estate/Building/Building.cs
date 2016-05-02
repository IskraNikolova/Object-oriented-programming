namespace Estates.Models.Estate.Building
{
    using Estates.Interfaces;

    public abstract class Building : Estate, IBuildingEstate
    {
        protected Building()
        {
            this.Rooms = Rooms;
            this.HasElevator = HasElevator;
        }

        public int Rooms { get; set; }

        public bool HasElevator { get; set; }

        public override string ToString()
        {
            string isElevator = this.HasElevator ? "Yes" : "No";
            return base.ToString() + $", Rooms: {this.Rooms}, Elevator: {isElevator}";
        }
    }
}