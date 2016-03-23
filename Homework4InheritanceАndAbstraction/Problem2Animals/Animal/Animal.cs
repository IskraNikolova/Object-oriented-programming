namespace Problem2Animals.Animal
{

    using System;
    using Problem2Animals.Interface;

    public abstract class Animal : ISoundProducible
    {
        const int MinAge = 0;
        const int MaxAge = 30;

        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be empty!");
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
                if (value < MinAge && value > MaxAge)
                {
                    throw new ArgumentNullException(nameof(value), $"Age must be in range[{MinAge}...{MaxAge}]!");
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Gender cannot be empty!");
                }

                this.gender = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return $"I am a {GetType().Name}, my name is {this.Name}. I am {this.Age} years old.\nMy gender is {this.Gender}";
        }
    }
}