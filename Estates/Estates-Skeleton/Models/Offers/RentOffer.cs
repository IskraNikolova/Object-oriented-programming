namespace Estates.Models.Offers
{
    using Estates.Interfaces;

    public class RentOffer : Offer, IRentOffer
    {
        public RentOffer()
        {
            this.Type = OfferType.Rent;
            this.PricePerMonth = PricePerMonth;
        }

        public decimal PricePerMonth { get; set; }

        public override string ToString()
        {
            return $"{this.Type}: " + base.ToString() + $", Price = {this.PricePerMonth}";
        }
    }
}
