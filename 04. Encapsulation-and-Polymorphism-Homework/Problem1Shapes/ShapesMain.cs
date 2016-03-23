namespace Problem1Shapes
{
    using System;
    using Problem1Shapes.Interfaces;
    using Problem1Shapes.Shape;

    public class ShapesMain
    {
        public static void Main()
        {
            double sizeA = 4.5;
            double sizeB = 5.5;
            double radius = 6.7;
            int lengthOfShapesCollection = 3;

            IShape[] shapes = new IShape[lengthOfShapesCollection];
            shapes[0] = new Circle(radius);
            shapes[1] = new Rectangle(sizeA, sizeB);
            shapes[2] = new Rhombus(sizeA);

            foreach (var shape in shapes)
            {
                string shapesType = shape.GetType().Name;

                double area = shape.CalculateArea();
                Console.WriteLine($"{shapesType} area is {area:F2}cm.");

                double perimeter = shape.CalculatePerimeter();
                Console.WriteLine($"{shapesType} perimeter is {perimeter:F2}cm.");
            }
        }
    }
}