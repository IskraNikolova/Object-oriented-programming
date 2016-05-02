namespace Estates.Models.Estate.Building
{
    using Estates.Interfaces;

    public class Office : Building, IOffice
    {
        public Office()
        {
            this.Type = EstateType.Office;
        }
    }
}
