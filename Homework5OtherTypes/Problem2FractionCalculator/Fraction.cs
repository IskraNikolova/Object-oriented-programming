namespace Problem2FractionCalculator
{
    using System;
    using System.Globalization;

    public struct Fraction
    {
        private decimal denominator;

        public Fraction(decimal numerator, decimal denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public decimal Numerator { get; private set; }

        public decimal Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArithmeticException("Denomerator cannot be 0.");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            decimal newNumerator = (f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator);
            decimal newDenomerator = (f1.Denominator * f2.Denominator);

            return new Fraction(newNumerator, newDenomerator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            decimal newNumerator = (f1.Numerator * f2.Denominator) - (f2.Numerator * f1.Denominator);
            decimal newDenomerator = (f1.Denominator * f2.Denominator);

            return new Fraction(newNumerator, newDenomerator);
        }

        public override string ToString()
        {
            decimal res = this.Numerator / this.Denominator;
            string result = res.ToString(CultureInfo.InvariantCulture);

            return result;
        }
    }
}
