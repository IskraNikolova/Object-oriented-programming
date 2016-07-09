using Kermen.Interfaces;

namespace Kermen.Models
{
    public abstract class Home : IHome
    {
        private decimal homeBudget;

        protected Home(decimal profit)
        {
            this.Profit = profit;
            this.CountOfRooms = CountOfRooms;
            this.RoomsElectricityCost = RoomsElectricityCost;
            this.homeBudget = 0;
        }

        public virtual int Population
        {
            get
            {
                return 1;
            }
        }

        public decimal Profit { get; }

        public decimal CountOfRooms { get; protected set; }

        public int RoomsElectricityCost { get; protected set; }

        public bool IsAbleToPay
        {
            get
            {
                return this.homeBudget >= this.Consumption;
            }
        }

        public virtual decimal Consumption
        {
            get
            {
                return this.CountOfRooms * RoomsElectricityCost;
            }
        }

        public void Bill()
        {
            this.homeBudget -= this.Consumption;         
        }

        public virtual void PaySalary()
        {
            this.homeBudget += this.Profit;
        }
    }
}
