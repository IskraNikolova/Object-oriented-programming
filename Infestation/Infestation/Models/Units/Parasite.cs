namespace Infestation.Models.Units
{
    public class Parasite : InfestorUnit
    {
        public Parasite(string id) 
            : base(id, UnitClassification.Biological, 1, 1, 1)
        {
        }
    }
}
