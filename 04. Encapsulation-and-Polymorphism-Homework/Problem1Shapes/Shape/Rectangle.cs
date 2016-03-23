namespace Problem1Shapes.Shape
{
    public class Rectangle : BasicShape
    {
        private const int Мultiplier = 2;

        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            double area = this.Height * this.Width;

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (this.Height * Мultiplier) + (this.Width * Мultiplier);

            return perimeter;
        }
    }
}