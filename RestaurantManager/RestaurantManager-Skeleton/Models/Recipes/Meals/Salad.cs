namespace RestaurantManager.Models.Recipes.Meals
{

    using RestaurantManager.Interfaces;

    public class Salad : Meal, ISalad
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isContainPasta) 
            : base(name, price, calories, quantityPerServing, timeToPrepare, true)
        {
            this.ContainsPasta = isContainPasta;
        }

        public bool ContainsPasta { get; }

        public override string ToString()
        {
            string yesOrNo = this.ContainsPasta ? "yes" : "no";
            string vegan = this.IsVegan ? "[VEGAN] " : "";

            return vegan + base.ToString() + $"\nContains pasta: {yesOrNo}";
        }
    }
}
