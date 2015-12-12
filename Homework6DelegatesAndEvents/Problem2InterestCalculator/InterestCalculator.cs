using System;
using System.Globalization;
using System.Threading;

namespace Problem2InterestCalculator
{
    public delegate decimal CalculateInterestDelegate(decimal money, decimal interest, int years);

    public class InterestCalculator
    {
        private readonly CalculateInterestDelegate inerestDelegate;

        private decimal money;
        private decimal interest;
        private int years;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterestDelegate inerestDelegate)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.inerestDelegate = inerestDelegate;
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Money cannot be negative.");
                }
                this.money = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Interest cannot be negative.");
                }
                this.interest = value;
            }
        }
        public int Years
        {
            get { return this.years; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Years cannot be negative.");
                }
                this.years = value;
            }
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
            return $"{this.inerestDelegate(this.Money, this.Interest, this.Years):F4}lv.";
        }
    }
}
