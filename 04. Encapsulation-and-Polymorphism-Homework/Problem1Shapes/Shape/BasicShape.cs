namespace Problem1Shapes.Shape
{
    using System;
    using Problem1Shapes.Interfaces;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Width cannot be a negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Height cannot be a negative.");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

    }
}