namespace Mordor_s_Cruelty_Plan.Factories
{
    using Mordor_s_Cruelty_Plan.Foods;

    public class FoodFactory
    {
        public Food CreateFood(string input)
        {
            switch (input.Trim().ToLower())
            {
                case "cram":
                    return new Cram();
                case "apple":
                    return new Apple();
                case "honeycake":
                    return new HoneyCake();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "mushrooms":
                    return new Mushrooms();
            }

            return new OtherFood();
        }
    }
}
