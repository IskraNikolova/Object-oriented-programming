namespace WildFarm.Models.Mammals
{
    using System;
    using WildFarm.Foods;

    public class Zebra : Mammal
    {
        public Zebra(string animalName, double animalWeight, string leavingRegion) 
            : base(animalName, animalWeight, leavingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable")
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
