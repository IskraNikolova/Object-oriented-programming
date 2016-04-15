namespace Problem2InterestCalculator
{
    using System;

    public class MainTest
    {
        public static void Main()
        {
            var compound = new InterestCalculator(800.0m, 3.2m, 5, GetCompoundInterest);
            Console.WriteLine(compound);

            var simple = new InterestCalculator(1000.0m, 3.2m, 10, GetSimpleInterest);
            Console.WriteLine(simple);
        }

        private static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            return money * (1 + (interest / 100) * years);
        }

        private static decimal GetCompoundInterest(decimal money, decimal interest, int years)
        {
            int monthsForYear = 12;

            return money * (decimal) Math.Pow((double) (1 + (interest / 100) / monthsForYear), monthsForYear * years);
        }
    }
 }