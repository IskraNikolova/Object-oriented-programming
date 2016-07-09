using PizzaCalories.Models;

namespace PizzaCalories.Core
{
    public class ToppingFactory
    {
        public Topping CreateTopping(string input)
        {
            //Topping Veggies 50
            var toppingtype = input.Split()[1];
            double grams = double.Parse(input.Split()[2]);

            return new Topping(toppingtype, grams);
        }
    }
}
