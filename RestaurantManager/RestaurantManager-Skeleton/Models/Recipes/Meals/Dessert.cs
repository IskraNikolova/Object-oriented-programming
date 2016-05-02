namespace RestaurantManager.Models.Recipes.Meals
{

    using RestaurantManager.Interfaces;

    public class Dessert : Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan) 
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = true;
        }

        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !WithSugar;
        }

        public override string ToString()
        {
            string withShugar = this.WithSugar ? "" : "[NO SUGAR] ";
            string vegan = this.IsVegan ? "[VEGAN] " : "";
            string result = withShugar + vegan;
           
            return result + base.ToString();
        }
    }
}
