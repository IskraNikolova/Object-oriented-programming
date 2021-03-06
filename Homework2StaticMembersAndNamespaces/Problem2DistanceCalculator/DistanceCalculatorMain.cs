﻿namespace Problem2DistanceCalculator
{
    using System;
    using Problem1Point3D;

    public class DistanceCalculatorMain
    {
        //Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space. 
        //Search in Internet how to calculate distance in the 3D Euclidian space.

       public static void Main()
        {
            Point3D firstPoint = new Point3D(3, 4, 2);
            Point3D secondPoint = new Point3D(6, 4, 2);

            double distance = DistanceCalculator.Calculate3DPointDistance(firstPoint, secondPoint);
            Console.WriteLine("Distance: {0}",distance);
        }
    }
}