namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        public ShoppingCart()
        {
            this.Products = new List<IProduct>();
        }

        public IList<IProduct> Products { get; }

        public void AddProduct(IProduct product)
        {
            this.Products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            if (this.Products.Contains(product))
            {
                this.Products.Remove(product);
            }
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.Products.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal sum = 0;
            foreach (var product in this.Products)
            {
                sum += product.Price;
            }

            return sum;
        }
    }
}
