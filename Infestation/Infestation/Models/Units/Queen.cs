namespace Infestation.Models.Units
{
    public class Queen : InfestorUnit
    {
        private const int DefaultHealth = 30;
        public Queen(string id) 
            : base(id, UnitClassification.Psionic, DefaultHealth, 1, 1)
        {
        }
    }
}
