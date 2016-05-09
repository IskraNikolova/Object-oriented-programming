using System;

namespace GenericList
{
    public class Program
    {
        public static void Main()
        {
            GenericList<int> demoList = new GenericList<int>();
            demoList.Add(8);
            demoList.Add(4);
            demoList.Add(5);

            demoList.Remove(1);
            demoList.Insert(3, 1);

            var result = demoList.Contains(8);
            var item = demoList[2];
            Console.WriteLine(item);
        }
    }
}