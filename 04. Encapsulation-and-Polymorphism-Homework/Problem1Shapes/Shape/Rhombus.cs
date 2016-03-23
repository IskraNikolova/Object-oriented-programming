namespace Problem1Shapes.Shape
{
    public class Rhombus : BasicShape
    {
        private const int Мultiplier = 4;

        public Rhombus(double size)
            : base(size, size)
        {
        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Width;

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = Мultiplier * this.Width;

            return perimeter;
        }
    }
}