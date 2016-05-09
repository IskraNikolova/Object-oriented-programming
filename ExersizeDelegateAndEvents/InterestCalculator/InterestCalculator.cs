using System;

namespace InterestCalculator
{
    public class InterestCalculator
    {
        private Func<decimal, decimal, int, decimal> calculateInterest;

        private decimal sumOfMoney;
        private decimal interest;
        private int years;
     
        public InterestCalculator(decimal sumOfMoney, decimal interest, int years, Func<decimal, decimal, int, decimal> calculateInterest)
        {
            this.sumOfMoney = sumOfMoney;
            this.interest = interest;
            this.years = years;
            this.calculateInterest = calculateInterest;
        }

        public override string ToString()
        {
            var result = this.calculateInterest(this.sumOfMoney, this.interest, this.years);

            return $"{result:F2}";
        }
    }
}