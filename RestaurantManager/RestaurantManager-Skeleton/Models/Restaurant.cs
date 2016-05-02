using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Restaurant : IRestaurant
    {
        private string name;

        public Restaurant(string name, string location, IList<IRecipe> recipes)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = recipes;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of restaurant is required.");
                }

                this.name = value;
            }
        }

        public string Location { get; }

        public IList<IRecipe> Recipes { get; }

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            string result = string.Empty;
            sb.AppendLine($"***** {this.Name} - {this.Location} *****");
            if (this.Recipes.Count == 0)
            {
                sb.Append("No recipes... yet");
                result = sb.ToString();
            }
            else
            { 
                List<IDrink> drinks = new List<IDrink>();
                List<ISalad> salads = new List<ISalad>();
                List<IMainCourse> mainCourses = new List<IMainCourse>();
                List<IDessert> dessert = new List<IDessert>();
                foreach (var recipe in this.Recipes)
                {
                    if (recipe is IDrink)
                    {
                        drinks.Add(recipe as IDrink);
                    }
                    else if(recipe is ISalad)
                    {
                        salads.Add(recipe as ISalad);
                    }
                    else if (recipe is IMainCourse)
                    {
                        mainCourses.Add(recipe as IMainCourse);
                    }
                    else if (recipe is IDessert)
                    {
                        dessert.Add(recipe as IDessert);
                    }
                }

                if (drinks.Count > 0)
                {
                    var orderedDrinks = drinks.OrderBy(d => d.Name);
                    sb.AppendLine("~~~~~ DRINKS ~~~~~");
                    foreach (var drink in orderedDrinks)
                    {
                        sb.AppendLine(drink.ToString());
                    }
                }
                if (salads.Count > 0)
                {
                    var orderedSalad = salads.OrderBy(s => s.Name);
                    sb.AppendLine("~~~~~ SALADS ~~~~~");
                    foreach (var salad in orderedSalad)
                    {
                        sb.AppendLine(salad.ToString());
                    }
                }
                if (mainCourses.Count > 0)
                {
                    var orderedmain = mainCourses.OrderBy(m => m.Name);
                    sb.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                    foreach (var mainCourse in orderedmain)
                    {
                        sb.AppendLine(mainCourse.ToString());
                    }
                }
                if (dessert.Count > 0)
                {
                    var orderedDessert = dessert.OrderBy(d => d.Name);
                    sb.AppendLine("~~~~~ DESSERTS ~~~~~");
                    foreach (var desert in orderedDessert)
                    {
                        sb.AppendLine(desert.ToString());
                    }             
                }

                string resultToString = sb.ToString();
                result = resultToString.Substring(0, resultToString.Length - 1);
            }
    
            return result;
        }
    }
}
