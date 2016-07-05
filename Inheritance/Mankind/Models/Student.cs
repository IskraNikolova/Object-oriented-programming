namespace Mankind.Models
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                bool isCorrect = true;
                foreach (var ch in value)
                {
                    if (!char.IsDigit(ch) && !char.IsLetter(ch))
                    {
                        isCorrect = false;
                    }
                }

                if ((value.Length < 5 || value.Length > 10) || !isCorrect)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Faculty number: {this.FacultyNumber}");

            return base.ToString() + output;
        }
    }
}
