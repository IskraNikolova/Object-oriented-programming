using System;
using PizzaCalories.Enums;
using PizzaCalories.Models;

namespace PizzaCalories.Core
{
    public class DoughFactory
    {
        public Dough CreateDough(string input)
        {
            //Dough Wholegrain Crispy 100
            var flourType = input.Split()[1].ToLower();
            var backType = input.Split()[2].ToLower();
            double grams = double.Parse(input.Split()[3]);

            return new Dough(flourType, backType, grams);
        }
    }
}
