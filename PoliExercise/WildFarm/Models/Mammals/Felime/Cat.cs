namespace WildFarm.Models.Mammals.Felime
{
    using System;
    using WildFarm.Foods;

    public class Cat : Felime
    {
        private string breed;

        public Cat(string animalName, double animalWeight, string leavingRegion, string breed) 
            : base(animalName, animalWeight, leavingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Breed can not be null.");
                }
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            //{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]
            return $"{this.GetType().Name}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LeavingRegion}, {this.FoodEaten}]";
        }
    }
}
