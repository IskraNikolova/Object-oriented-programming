
using System;

namespace FootballLeague.Models
{
    public class Player
    {
        private const int MinumumAllowedYear = 1980;

        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private decimal salary;
        private Team team;


        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Salary = salary;
            this.Team = team;
        }

        public string FirstName {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name should be at least 3 chars long");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Last name should be at least 3 chars long");
                }
                this.lastName = value;
            }
        }
        public DateTime DateOfBirth {
            get { return this.dateOfBirth; }
            set
            {
                if (value.Year > MinumumAllowedYear)
                {
                    throw new ArgumentException("Date of birth cannot be earlier than" + MinumumAllowedYear);
                }
                this.dateOfBirth = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }
                this.salary = value;
            }
        }

        public Team Team { get; set; }
    }
}
