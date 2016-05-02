namespace Estates.Models.Offers
{
    using Estates.Interfaces;

    public class Offer : IOffer
    {
        public Offer()
        {
            this.Type = Type;
            this.Estate = Estate;
        }

        public OfferType Type { get; set; }

        public IEstate Estate { get; set; }

        public override string ToString()
        {
            return $"Estate = {this.Estate.Name}, Location = {this.Estate.Location}";
        }
    }
}
