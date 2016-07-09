using System;

namespace ShoppingSpree
{
    public class CanAffordException : Exception
    {
        public CanAffordException(string personName, string  productName)
            :base($"{personName} can't afford {productName}")
        {            
        }
    }
}
