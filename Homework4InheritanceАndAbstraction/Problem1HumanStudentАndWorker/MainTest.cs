using System;
using System.Collections.Generic;
using System.Linq;

public class MainTest
{
    public static void Main()
    {
        var workers = new List<Worker>
        {
            new Worker("Pesh", "Peshev", 1000, 12),
            new Worker("Mesh", "Peshev", 1250, 8),
            new Worker("Kesh", "Teshev", 7000, 6),
            new Worker("Cesh", "Peev", 700, 12),
            new Worker("Tresh", "Smesh", 870, 14),
            new Worker("Bivan", "Ivanow", 1200, 8),
            new Worker("Kitka", "Kitkewa", 400, 12),
            new Worker("Asen", "Abenov", 290, 4),
            new Worker("Misho", "Mishev", 1600, 12),
            new Worker("Svilen", "Troshev", 3000, 8)
        };

        var ordered =  workers.OrderByDescending(a => a.MoneyPerHour());
        Console.WriteLine(string.Join("\n", ordered));
        Console.WriteLine("***************************");

        var students = new List<Student>
        {
            new Student("Anka", "Ankova", 23456187),
            new Student("Botko", "Cetkova", 46546165),
            new Student("Cora", "Krumova", 19875678),
            new Student("Moi", "Boi", 33456198),
            new Student("Walq", "Radewa", 88876560),
            new Student("Minka", "Kinkova", 98234563),
            new Student("Tonka", "Tonkova", 98723456),
            new Student("Yavor", "Valev", 88823456),
            new Student("Mea", "Koi", 86923456),
            new Student("Zara", "Kinkova", 11123456)
        };

        var orderedStudents = students.OrderBy(a => a.FacultyNumber);
        Console.WriteLine(string.Join("\n", orderedStudents));

        var humans = new List<Human>();
        humans.AddRange(workers);
        humans.AddRange(students);

        Console.WriteLine("***************************");
        var orderedByName = humans.OrderBy(a => a.FirstName).ThenBy(a => a.LastName);
        Console.WriteLine(string.Join("\n", orderedByName));
    }
}

