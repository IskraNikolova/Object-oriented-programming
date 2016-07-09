namespace Kermen.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Child
    {
        public Child(List<decimal> consumations)
        {
            this.Consumations = consumations;
        }

        public List<decimal> Consumations { get; }

        public decimal CalculateSumOfConsum()
        {
            return this.Consumations.Sum();
        }
    }
}
