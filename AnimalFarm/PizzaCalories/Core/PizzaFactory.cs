using System.Runtime.CompilerServices;
using PizzaCalories.Models;

namespace PizzaCalories.Core
{
    public class PizzaFactory
    {
        
        public Pizza CreatePizza(string name, int numberOfToppings)
        {
            return new Pizza(name, numberOfToppings);
        }
    }
}
