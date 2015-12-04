using System.Globalization;
using System.Runtime;

namespace Problem2FractionCalculator
{
    public struct Fraction
    {
        private decimal numerator;
        private decimal denominator;

        public Fraction(decimal numerator, decimal denominator) 
            : this()      
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public decimal Numerator { get; set; }
        public decimal Denominator { get; set; }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            decimal newNumerator = (f1.Numerator*f2.Denominator) + (f2.Numerator*f1.Denominator);
            decimal newDenumerator = (f1.Denominator*f2.Denominator);
            return new Fraction(newNumerator, newDenumerator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            decimal newNumerator = (f1.Numerator * f2.Denominator) - (f2.Numerator * f1.Denominator);
            decimal newDenumerator = (f1.Denominator * f2.Denominator);
            return new Fraction(newNumerator, newDenumerator);
        }

        public override string ToString()
        {
            decimal res = this.Numerator/this.Denominator;
            string result = res.ToString();
            return result;
        }
    }
}
