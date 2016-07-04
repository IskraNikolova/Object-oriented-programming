namespace WildFarm.Models.Mammals
{
    using System;
    using WildFarm.Foods;

    public class Mouse : Mammal
    {
        public Mouse(string animalName, double animalWeight, string leavingRegion) 
            : base(animalName, animalWeight, leavingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable")
            {
                this.FoodEaten += food.Quantity;
                Console.WriteLine("A cheese was just eaten!");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
            }
        }
    }
}
