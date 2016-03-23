namespace Problem3CompanyHierarchy.Person.Employee
{

    using System;
    using Problem3CompanyHierarchy.Interfaces;

    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private string department;

        public Employee(string id, string firstName, string lastName, decimal salary, string department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException(nameof(value), "Salary cannot be negative!");
                }

                this.salary = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }

            set
            {
                if (value != "Production" && value != "Accounting" && value != "Sales" && value != "Marketing")
                {
                    throw new FormatException("Department must be: Production\\Accounting\\Sales\\Marketing");
                }

                this.department = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSalary: {this.Salary}\nDepartment: {this.Department}";
        }
    }
}