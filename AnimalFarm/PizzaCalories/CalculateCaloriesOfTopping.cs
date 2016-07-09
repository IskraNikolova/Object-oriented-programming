using System.Runtime.Remoting.Messaging;
using PizzaCalories.Enums;
using PizzaCalories.Models;

namespace PizzaCalories
{
    public static class CalculateCaloriesOfTopping
    {
        public static int BaseCalories = 2;

        public static double CalculateToppingCalories(Topping topping)
        {
            double calories = TakeCaloriesOfModifier(topping);
            double result = (topping.Grams*BaseCalories)*calories;

            return result;
        }

        private static double TakeCaloriesOfModifier(Topping topping)
        {
            switch (topping.ToppingType.ToLower())
            {
                case "meat":
                    return 1.2;
                case "veggies":
                    return 0.8;
                case "cheese":
                    return 1.1;
                case "sauce":
                    return 0.9;
            }

            return 0;
        }
    }
}
