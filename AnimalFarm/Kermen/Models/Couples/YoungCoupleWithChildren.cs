using System.Linq;

namespace Kermen.Models.Couples
{
    using System.Collections.Generic;

    public class YoungCoupleWithChildren : YoungCouple
    {
        public YoungCoupleWithChildren(decimal profit, 
            decimal tVCoast,
            decimal fridgeCoast, 
            decimal laptopCost,
            List<Child> children) 
            : base(profit, tVCoast, fridgeCoast, laptopCost)
        {
            this.CountOfRooms = 2;
            this.RoomsElectricityCost = 30;
            this.Children = children;
        }

        public List<Child> Children { get; }

        public override decimal Consumption
        {
            get
            {
                return this.Children.Sum(c => c.CalculateSumOfConsum()) + base.Consumption;
            }
        }

        public override int Population
        {
            get
            {
                return this.Children.Count + base.Population;
            }
        }
    }
}
