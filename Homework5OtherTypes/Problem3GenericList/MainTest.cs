using System;

namespace Problem3GenericList
{
    public class MainTest
    {
        public static void Main()
        {
            GenericList<string> names = new GenericList<string>();
            names.Add("Pipi");
            names.Add("Lili");
            names.Add("Bobo");
            names.Add("Miroslav");

            Console.WriteLine(names); //Print GenericList with override ToString()
            Console.WriteLine();

            Console.WriteLine($"Length of list is {names.Length}."); // collection has length
            Console.WriteLine();

            names.Remove(0);
            Console.WriteLine(names);
            Console.WriteLine();

            names.Insert(2, "New name - Isi");
            Console.WriteLine(names);

            Console.WriteLine();
            Console.WriteLine(names.Contains("Bobo") + " - that contains");

            Console.WriteLine();
            Console.WriteLine($"Index of this value is {names.Find("Lili")}.");
            Console.WriteLine();

            names.Clear();
            Console.WriteLine(names + " - Collection is clear");
            Console.WriteLine();

            GenericList<int> ints = new GenericList<int>();
            ints[0] = 1; // add value on the position
            ints[1] = 2;
            ints[2] = 3;
            ints[3] = 4;
       
            Console.WriteLine("Min value is " + Min(ints));
            Console.WriteLine("Max value is " + Max(ints));
            
        }

        /// <summary>
        /// Search min value
        /// </summary>
        /// <typeparam name="T">all types</typeparam>
        /// <param name="list">GenericList of all types</param>
        /// <returns>min value</returns>
        public static T Min<T>(GenericList<T> list)
            where T : IComparable<T>
        {
            T min = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].CompareTo(min) < 0)
                {
                    min = list[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Search max value
        /// </summary>
        /// <typeparam name="T">all types</typeparam>
        /// <param name="list">GenericList of all types</param>
        /// <returns></returns>
        public static T Max<T>(GenericList<T> list)
       where T : IComparable<T>
        {
            T max = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
