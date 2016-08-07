namespace Kermen.Models.Couples
{
    public class OldCouple : CoupleHome
    {
        public OldCouple(decimal profit,
            decimal tVCoast,
            decimal fridgeCoast,
            decimal stove) 
            : base(profit, 3, 15, tVCoast, fridgeCoast)
        {
            this.Stove = stove;
        }

        public decimal Stove { get; }

        public override decimal Consumption
        {
            get
            {
                return this.Stove + base.Consumption;
            }
        }
    }
}
