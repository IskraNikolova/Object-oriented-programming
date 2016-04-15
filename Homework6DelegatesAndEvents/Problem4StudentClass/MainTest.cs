namespace Problem4StudentClass
{
    using System;

    public class MainTest
    {
        public static void Main()
        {
            var student = new Student("Koko", 19);
            student.OnChange += EventChanges;
            student.Name = "Milko";
            student.Age = 21;
        }
    
        private static void EventChanges(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine(
                $"Property changed: {args.PropName} (from {args.First} to {args.Second})");
        }
    }
}