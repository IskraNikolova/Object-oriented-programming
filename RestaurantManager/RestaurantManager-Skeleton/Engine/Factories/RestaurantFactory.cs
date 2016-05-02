namespace RestaurantManager.Engine.Factories
{
    using System.Collections.Generic;
    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;
    using RestaurantManager.Models;

    public class RestaurantFactory : IRestaurantFactory
    {
        public IRestaurant CreateRestaurant(string name, string location)
        {
            return new Restaurant(name, location, new List<IRecipe>());
        }
    }
}
