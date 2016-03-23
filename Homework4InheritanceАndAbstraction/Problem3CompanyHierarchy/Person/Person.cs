namespace Problem3CompanyHierarchy.Person
{
    using System;
    using Problem3CompanyHierarchy.Interfaces;

    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        protected Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value.Length < 10)
                {
                    throw new FormatException("Invalid ID!");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "First name cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Last name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {this.ID} Full Name: {this.FirstName} {this.LastName}";
        }
    }
}