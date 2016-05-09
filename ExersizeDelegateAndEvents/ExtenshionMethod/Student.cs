using System;

namespace ExtenshionMethod
{
    public class Student
    {
        public Student(string name, int age, double averageGrade)
        {
            this.Name = name;
            this.Age = age;
            this.AvaregeGrade = averageGrade;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public double AvaregeGrade { get; set; }
    }
}