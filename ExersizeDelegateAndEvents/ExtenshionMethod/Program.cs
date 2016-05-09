using System;
using System.Collections.Generic;

namespace ExtenshionMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> number = new List<int>()
            {
                3,
                4,
                5,
                6,
                1,
                7
            };
            var orderNumber = number.OrderEnumerable(n => n);
            Console.WriteLine(string.Join(".", orderNumber));
            var filterList = number.Filter(n => n % 2 != 0);
            var res = number.WhereNot(n => n < 5);
            ;

            Console.WriteLine(string.Join(" ", filterList));
            Console.WriteLine(string.Join(" ", res) + "new");

            Student misho = new Student("Aisho", 10, 5);
            Student gosho = new Student("Gosho", 20, 6);
            Student minka = new Student("Binka", 40, 4);
            Student koko = new Student("Coko", 30, 2);



            List<Student> studentCollection = new List<Student>();
            studentCollection.Add(misho);
            studentCollection.Add(gosho);
            studentCollection.Add(minka);
            studentCollection.Add(koko);
            var orderListOfStudentByName = studentCollection.OrderEnumerable(st => st.Name);

            Console.WriteLine(string.Join("\n", orderListOfStudentByName));

            var age = studentCollection.Project(st => st.Age);
            var stres = studentCollection.WhereNot(st => st.Name.StartsWith("K"));

            foreach (var s in stres)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine(string.Join(" ", age));
        }
    }
}