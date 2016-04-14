namespace Problem1CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public class MainTest
    {
        public static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var filteredCollect = nums.WhereNot(num => num % 2 == 0);

            Console.WriteLine(string.Join(", ", filteredCollect));

            var students = new List<Student>()
            {
                new Student("Pipo", 3.50),
                new Student("Miko", 2.99),
                new Student("Maq", 6.0)
            };

            Console.WriteLine(students.MaxElement(st => st.Grades));
        }
    }
}