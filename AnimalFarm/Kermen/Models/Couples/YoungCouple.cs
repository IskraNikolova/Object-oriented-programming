using Kermen.Interfaces;

namespace Kermen.Models.Couples
{
    public class YoungCouple : CoupleHome, IYoung
    {
        public YoungCouple(decimal profit,
            decimal tVCoast,
            decimal fridgeCoast,
            decimal laptopCost)
            : base(profit, tVCoast, fridgeCoast)
        {
            this.CountOfRooms = 2;
            this.RoomsElectricityCost = 20;
            this.LaptopCoast = laptopCost;
        }

        public decimal LaptopCoast { get; }

        public override decimal Consumption
        {
            get
            {
                return (this.LaptopCoast * 2) + base.Consumption;
            }
        }
    }
}
