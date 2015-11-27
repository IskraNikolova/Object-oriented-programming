using System;
using Problem1Shapes;

public class ShapesMain
{
    public static void Main()
    {
        double a = 4.5;
        double b = 5.5;
        double r = 6.7;
        int lengthOfArray = 3;

        IShape[] shapes = new IShape[lengthOfArray];
        shapes[0] = new Circle(r);
        shapes[1] = new Rectangle(a, b);
        shapes[2] = new Rhombus(a, a);

        foreach (var shape in shapes)
        {
            Console.WriteLine("{0} area is {1:F2}cm.",shape.GetType(), shape.CalculateArea());
            Console.WriteLine("{0} perimeter is {1:F2}cm.",shape.GetType(), shape.CalculatePerimeter());
            Console.WriteLine("************************");
        }
    }
}

