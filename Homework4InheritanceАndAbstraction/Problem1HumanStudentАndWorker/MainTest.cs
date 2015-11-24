using System;
using System.Collections.Generic;
using System.Linq;

public class MainTest
{
    public static void Main()
    {
        List<Worker> workers = new List<Worker>();
        workers.Add(new Worker("Pesh", "Peshev", 1000, 12));
        workers.Add(new Worker("Mesh", "Peshev", 1250, 8));
        workers.Add(new Worker("Kesh", "Teshev", 7000, 6));
        workers.Add(new Worker("Cesh", "Peev", 700, 12));
        workers.Add(new Worker("Tresh", "Smesh", 870, 14));
        workers.Add(new Worker("Bivan", "Ivanow", 1200, 8));
        workers.Add(new Worker("Kitka", "Kitkewa", 400, 12));
        workers.Add(new Worker("Asen", "Abenov", 290, 4));
        workers.Add(new Worker("Misho", "Mishev", 1600, 12));
        workers.Add(new Worker("Svilen", "Troshev", 3000, 8));

        var ordered =  workers.OrderByDescending(a => a.MoneyPerHour());
        Console.WriteLine(string.Join("\n", ordered));
        Console.WriteLine("***************************");

        List<Student> students = new List<Student>();
        students.Add(new Student("Anka", "Ankova", 23456187));
        students.Add(new Student("Botko", "Cetkova", 46546165));
        students.Add(new Student("Cora", "Krumova", 19875678));
        students.Add(new Student("Moi", "Boi", 33456198));
        students.Add(new Student("Walq", "Radewa", 88876560));
        students.Add(new Student("Minka", "Kinkova", 98234563));
        students.Add(new Student("Tonka", "Tonkova", 98723456));
        students.Add(new Student("Yavor", "Valev", 88823456));
        students.Add(new Student("Mea", "Koi", 86923456));
        students.Add(new Student("Zara", "Kinkova", 11123456));
        
        var orderedStudents = students.OrderBy(a => a.FacultyNumber);
        Console.WriteLine(string.Join("\n", orderedStudents));

        List<Human> humans = new List<Human>();
        humans.AddRange(workers);
        humans.AddRange(students);

        Console.WriteLine("***************************");
        var orderedByName = humans.OrderBy(a => a.FirstName).ThenBy(a => a.LastName);
        Console.WriteLine(string.Join("\n", orderedByName));
    }
}

