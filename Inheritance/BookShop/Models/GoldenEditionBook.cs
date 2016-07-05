namespace BookShop.Models
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {
        }

        public override decimal Price
        {
            get
            {
                decimal precent = (base.Price * 30) / 100;
                return base.Price + precent;
            }
        }
    }
}
