using System;

namespace Problem1Point3D
{
    public class Problem1Main
    {
        //Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Create appropriate constructors.
        //Override ToString() to enable printing a 3D point.
        // Add a private static read-only field in the Point3D class to hold the start of the coordinate system –
        //the point StartingPoint {0, 0, 0}. Add a static property to return the starting point.
        public static void Main()
        {
            Point3D point = new Point3D(3, 4, 5);

            Console.WriteLine(point);

            Console.WriteLine(Point3D.StartingPoint3D);
        }
    }
}
