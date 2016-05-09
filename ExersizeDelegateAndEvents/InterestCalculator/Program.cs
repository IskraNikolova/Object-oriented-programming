namespace InterestCalculator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            InterestCalculator simpleInterest = new InterestCalculator(2.5m, 1.8m, 6, GetSimpleInterest);
            Console.WriteLine(simpleInterest);

            InterestCalculator compoundInterest = new InterestCalculator(2.5m, 1.8m, 6, GetCompoundInterest);
            Console.WriteLine(compoundInterest);
        }

        private static decimal GetSimpleInterest(decimal sumOfMoney, decimal interest, int years)
        {
            return sumOfMoney * (1 + (interest / 100) * years);
        }

        private static decimal GetCompoundInterest(decimal money, decimal interest, int years)
        {
            int monthsForYear = 12;

            return money * (decimal)Math.Pow((double)(1 + (interest / 100) / monthsForYear), monthsForYear * years);
        }
    }
}