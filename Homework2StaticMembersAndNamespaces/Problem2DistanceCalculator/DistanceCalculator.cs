
using System;
using Problem1Point3D;

public static class DistanceCalculator
{
    public static double Calculate3DPointDistance(Point3D pointA, Point3D pointB)
    {
        return Math.Sqrt(
            Math.Pow(pointB.X - pointA.X, 2) +
            Math.Pow(pointB.Y - pointA.Y, 2) +
            Math.Pow(pointB.Z - pointA.Z, 2));
    }
}

