
using System;

namespace Problem4StudentClass
{
    public class MainTest
    {
        public static void Main()
        {
            var student = new Student("Koko", 19);
            student.OnPropertyChange += EventChanges;
            student.Name = "Milko";
            student.Age = 21;
        }
        //Property changed: Name (from Peter to Maria)

        private static void EventChanges(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine(
                $"Property changed: {args.PropName} (from {args.First} to {args.Second})");
        }
    }
}
