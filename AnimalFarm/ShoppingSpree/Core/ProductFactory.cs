using ShoppingSpree.Models;

namespace ShoppingSpree.Core
{
    public class ProductFactory
    {
        public Product CreateProduct(string data)
        {
            string[] args = data
                .Trim()
                .Split('=');

            return new Product(args[0], double.Parse(args[1]));
        }
    }
}
