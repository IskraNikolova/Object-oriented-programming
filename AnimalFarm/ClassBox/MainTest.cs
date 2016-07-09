namespace ClassBox
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class MainTest
    {
        public static void Main()
        {
            try
            {
                    Type boxType = typeof(Box);
                FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                Console.WriteLine(fields.Count());

                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());      
                Box box = new Box(length, width, height);
                Console.WriteLine(box);
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
