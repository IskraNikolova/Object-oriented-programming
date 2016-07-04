namespace WildFarm.Models.Mammals.Felime
{
    public abstract class Felime : Mammal
    {
        protected Felime(string animalName, double animalWeight, string leavingRegion) 
            : base(animalName, animalWeight, leavingRegion)
        {
        }
    }
}
