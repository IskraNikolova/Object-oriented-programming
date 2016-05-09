using System;

namespace StudentClassWithEvent
{
    public class Student
    {
        private const int MinAge = 1;
        private const int MaxAge = 110;

        public event PropertyChangedEventHandler OnChange;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null!");
                }

                if (this.OnChange != null)
                {
                    this.OnChange(this, new PropertyChangedEventArgs(this.name, value, "Name"));
                }
         
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {

                if (value < 0 || value > 110)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Age must be in range[{MinAge}...{MaxAge}]");
                }

                if (this.OnChange != null)
                {
                    this.OnChange(this, new PropertyChangedEventArgs(this.age, value, "Age"));
                }

                this.age = value;
            }
        }
    }
}