namespace Estates.Models.Offers
{
    using Estates.Interfaces;

    public class SaleOffer : Offer, ISaleOffer
    {
        public SaleOffer()
        {
            this.Type = OfferType.Sale;
            this.Price = Price;
        }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{this.Type}: " + base.ToString() + $", Price = {this.Price}";
        }
    }
}
