using System;
using System.Text;
using System.Xml;

namespace Mankind.Models
{
    public abstract class Human
    {
        string firstName;
        string lastName;

        protected Human(string firstName, string lastName)
        {
           this.FirstName = firstName;
           this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
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
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"First Name: {this.FirstName}");
            output.AppendLine($"Last Name: {this.LastName}");

            return output.ToString();
        }
    }
}
