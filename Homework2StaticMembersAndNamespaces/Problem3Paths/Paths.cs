namespace Problem3Paths
{
    using System;
    using Problem1Point3D;

    public class Paths
    {
        public static void Main()
        {
            Point3D point1 = new Point3D(5, 1, 0);
            Point3D point2 = new Point3D(20, 0, -3);
            Path3D path = new Path3D(point1, point2);

            Storage.SavePathToFile("path.txt", path.ToString());
            Console.WriteLine("Load from file:\n" + Storage.LoadPathFromFile("path.txt"));
        }
    }
}