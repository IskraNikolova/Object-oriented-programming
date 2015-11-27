
using Problem1Shapes;

public class Circle : IShape
{
    private const int Мultiplier = 2;
    private const double PI = 3.14;
    private double radius ;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius { get; set; }

    public double CalculateArea()
    {
        return PI * (this.Radius * this.Radius);
    }

    public double CalculatePerimeter()
    {
        return Мultiplier * PI * this.Radius;
    }
}

