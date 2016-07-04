namespace WildFarm.Models.Mammals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string animalName, double animalWeight, string leavingRegion) 
            : base(animalName, animalWeight)
        {
            this.LeavingRegion = leavingRegion;
        }

        public string LeavingRegion { get; set; }


        public override string ToString()
        {
            //{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LeavingRegion}, {this.FoodEaten}]";
        }
    }
}
