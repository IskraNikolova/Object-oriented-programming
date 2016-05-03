using System.Text;

namespace RestaurantManager.Models.Recipes.Meals
{
    using System;
    using RestaurantManager.Interfaces;

    public class MainCourse : Meal, IMainCourse
    {

        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = (MainCourseType)Enum.Parse(typeof(MainCourseType), type);
        }

        public MainCourseType Type { get; }

        public override string ToString()
        {
            string vegan = this.IsVegan ? "[VEGAN] " : "";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {this.Type}");

            return vegan + base.ToString() + sb;
        }
    }
}
