﻿
namespace Problem1HumanStudentАndWorker
{
    using System;

    public class Student : Human
    {
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value.ToString().Length < 5 && value.ToString().Length > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Faculty number must be in range[5...10]!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" - faculty number {this.FacultyNumber}";
        }
    }
}