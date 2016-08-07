using Kermen.Interfaces;

namespace Kermen.Models.Single
{
    public class AloneYoung : Home, IYoung
    {
        public AloneYoung(decimal profit, decimal laptopCoast) 
            : base(profit, 1, 10)
        {
            this.LaptopCoast = laptopCoast;
        }

        public decimal LaptopCoast { get; }

        public override decimal Consumption
        {
            get
            {
                return this.LaptopCoast + base.Consumption;
            }
        }
    }
}
