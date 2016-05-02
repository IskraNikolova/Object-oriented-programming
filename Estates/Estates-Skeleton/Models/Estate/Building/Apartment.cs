namespace Estates.Models.Estate.Building
{
    using Estates.Interfaces;

    public class Apartment : Building, IApartment
    {
        public Apartment()
        {
            this.Type = EstateType.Apartment;
        }   
    }
}
