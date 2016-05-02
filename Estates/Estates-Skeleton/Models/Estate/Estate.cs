namespace Estates.Models.Estate
{
    using System.Text;
    using Estates.Interfaces;

    public abstract class Estate : IEstate
    {
        protected Estate()
        {
            this.Name = Name;
            this.Type = Type;
            this.Area = Area;
            this.Location = Location;
            this.IsFurnished = IsFurnished;
        }

        public string Name { get; set; }

        public EstateType Type { get; set; }

        public double Area { get; set; }

        public string Location { get; set; }

        public bool IsFurnished { get; set; }

        public override string ToString()
        {
            string isFurnished = this.IsFurnished ? "Yes" : "No";
            StringBuilder sb = new StringBuilder();
            sb.Append(
                $"{this.Type}: Name = {this.Name}, " +
                $"Area = {this.Area}," +
                $" Location = {this.Location}," +
                $" Furnitured = {isFurnished}");

            return sb.ToString();
        }
    }
}
