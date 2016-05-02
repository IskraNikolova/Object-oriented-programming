namespace Infestation.Models.Units
{
    public class Tank : Unit
    {
        private const int DefaultHealth = 20;
        private const int DefaultPower = 25;
        private const int DefaultAggresion = 25;

        public Tank(string id)
            : base(id, UnitClassification.Mechanical, DefaultHealth, DefaultPower, DefaultAggresion)
        {
        }
    }
}
