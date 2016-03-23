namespace Problem1Shapes.Shape
{

    using System;
    using Problem1Shapes.Interfaces;

    public class Circle : IShape
    {
        private const int Мultiplier = 2;
        private const double PI = 3.14;
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Radius cannot be negative or null.");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = PI * (Math.Pow(this.Radius, 2));

            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = Мultiplier * PI * this.Radius;

            return perimeter;
        }
    }
}