﻿namespace Cosmetics.Engine
{
    using System.Collections.Generic;
    using Cosmetics.Products;
    using Common;
    using Contracts;

    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            return new Category(name);
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            return new Shampoo(name, brand, price, gender, milliliters, usage);
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            return new Toothpaste(name, brand, price, gender, ingredients);
        }

        public IShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
