
public class Rhombus : BasicShape
{
    private const int Мultiplier = 2;

    public Rhombus(double width, double height)
        : base(width, height)
    {
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }

    public override double CalculatePerimeter()
    {
        return (this.Height * Мultiplier) + (this.Width * Мultiplier);
    }

}

