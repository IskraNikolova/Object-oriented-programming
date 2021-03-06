﻿namespace Problem1Point3D
{
    public class Point3D
    {
        public Point3D(double y, double z, double x)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D StartingPoint3D { get; } = new Point3D(0, 0, 0);

        public override string ToString()
        {
            return this == StartingPoint3D ? $"Starting point: x={this.X}, y={this.Y}, z={this.Z}"  
                                           : $"Point: x={this.X}, y={this.Y}, z={this.Z}";
        }
    }
}