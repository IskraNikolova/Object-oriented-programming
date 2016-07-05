using System;
using Mankind.Models;

namespace Mankind
{
    public class TestMain
    {
        public static void Main()
        {
            string[] studentData = Console.ReadLine()
                .Trim()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            string firstStudentName = studentData[0];
            string lastStudentName = studentData[1];
            string facultyNumber = studentData[2];

            string[] workerData = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstWorkerName = workerData[0];
            string lastWorkerName = workerData[1];
            double salary = double.Parse(workerData[2]);
            double workingHours = double.Parse(workerData[3]);

            try
            {
                Student student = new Student(firstStudentName, lastStudentName, facultyNumber);
                Worker worker = new Worker(firstWorkerName, lastWorkerName, salary, workingHours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
