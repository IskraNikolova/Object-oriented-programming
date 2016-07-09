using Kermen.Interfaces;

namespace Kermen.Models.Couples
{
    public abstract class CoupleHome : Home, ICouple
    {
        protected CoupleHome(decimal profit, 
            decimal tVCoast, 
            decimal fridgeCoast)
            : base(profit)
        {
            this.TVCoast = tVCoast;
            this.FridgeCoast = fridgeCoast;
        }

        public decimal TVCoast { get; }

        public decimal FridgeCoast { get; }

        public override decimal Consumption
        {
            get
            {
                return base.Consumption + this.TVCoast + this.FridgeCoast;
            } 
        }

        public override int Population
        {
            get
            {
                return 1 + base.Population;
            }
        }
    }
}
