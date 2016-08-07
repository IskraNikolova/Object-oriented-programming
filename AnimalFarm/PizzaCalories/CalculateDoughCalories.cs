namespace PizzaCalories
{
    using PizzaCalories.Models;

    public static class CalculateDoughCalories
    {
        public static int BaseCalories = 2;
       

        public static double CalculateDoughCaloriesMethod()
        {
           // double floorType = TakeModifierToFloor();
            double backType = TakeModifierToBack(dough);
            double result = (BaseCalories * dough.Grams) * floorType * backType;

            return result;
        }

        private static double TakeModifierToBack(Dough dough)
        {
            switch (dough.FlourType.ToLower())
            {
                case "white":
                    return 1.5;
                case "wholegrain":
                    return 1.0;
            }

            return 0;
        }

        private static double TakeModifierToFloor(Dough dough)
        {
            switch (dough.BackType)
            {
                case "crispy":
                    return 0.9;
                case "chewy":
                    return 1.1;
                case "homemade":
                    return 1.0;
            }

            return 0;
        }
    }
}
