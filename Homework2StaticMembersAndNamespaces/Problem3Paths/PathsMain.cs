using System;
using Problem1Point3D;

namespace Problem3Paths
{
    public class PathsMain
    {
        private const string File = @"../../path.xml";

        public static void Main()
        {
            var path = new Path3D(
                new Point3D(1, 2, 3),
                new Point3D(4, 5, 2));
       
            Storage.SavePath(File, path);
            Path3D path2 = Storage.LoadPath(File);

            Console.WriteLine(string.Join(Environment.NewLine, path2.Path));
        }
    }
}

