namespace WildFarm.Models.Mammals.Felime
{
    using System;
    using WildFarm.Foods;

    public class Tiger : Felime
    {
        public Tiger(string animalName, double animalWeight, string leavingRegion) 
            : base(animalName, animalWeight, leavingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
            }
        }
    }
}
