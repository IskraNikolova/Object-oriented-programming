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
            sb.AppendLine($"***** {this.Name} - {this.Location} *****");
        
            if (!this.Recipes.Any())
            {
                sb.Append("No recipes... yet");
                return sb.ToString();
            }
                     
            var drinks = this.Recipes.Where(r => r is IDrink).OrderBy(r => r.Name);
            sb.Append(this.PrintArticles(drinks, "DRINKS"));

            var salads = this.Recipes.Where(r => r is ISalad).OrderBy(r => r.Name);
            sb.Append(this.PrintArticles(salads, "SALADS"));

            var mainCourses = this.Recipes.Where(r => r is IMainCourse).OrderBy(r => r.Name);
            sb.Append(this.PrintArticles(mainCourses, "MAIN COURSES"));

            var dessert = this.Recipes.Where(r => r is IDessert).OrderBy(r => r.Name);
            sb.Append(this.PrintArticles(dessert, "DESSERTS"));

       
            sb.Remove(sb.Length - 1, 1);
   
            return sb.ToString();
        }

        private string PrintArticles(IEnumerable<IRecipe> recipes, string title)
        {
            if (recipes.Count() == 0)
            {
                return string.Empty;
            }

            StringBuilder articlesAsString = new StringBuilder();
            recipes = recipes.OrderBy(r => r.Name);
            articlesAsString.AppendFormat("{0} {1} {0}", new string('~', 5), title).AppendLine();
            foreach (var recipe in recipes)
            {
                articlesAsString.Append(recipe);
            }

            return articlesAsString.ToString();
        }
    }
}