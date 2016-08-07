using System.Runtime.CompilerServices;
using Kermen.Interfaces;

namespace Kermen.Models.Couples
{
    public class YoungCouple : CoupleHome, IYoung
    {
        public YoungCouple(decimal profit,
            decimal tVCoast,
            decimal fridgeCoast,
            decimal laptopCost)
            : base(profit, 2, 20, tVCoast, fridgeCoast)
        {
            this.LaptopCoast = laptopCost;
        }

        protected YoungCouple(decimal profit, int countOfRooms, int roomsElectricityCost,
            decimal tVCoast,
            decimal fridgeCoast,
            decimal laptopCost)
            : base(profit,
                  countOfRooms, 
                  roomsElectricityCost,
                  tVCoast, 
                  fridgeCoast)
        {            
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
