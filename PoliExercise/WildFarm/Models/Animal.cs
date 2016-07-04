namespace WildFarm.Models
{
    using System;
    using WildFarm.Foods;

    public abstract class Animal
    {
        private string animalName;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = foodEaten;
        }

        public string AnimalName
        {
            get
            {
                return this.animalName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null.");
                }
            }
        }

        public double AnimalWeight
        {
            get { return this.animalWeight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException(nameof(value), "Weight cannot be zero or negative.");
                }
            }
        }

        public int FoodEaten
        {
            get
            {
                return this.foodEaten;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Food eaten canot be negative.");
                }
            }
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}