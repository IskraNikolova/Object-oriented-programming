
using System.Collections.Generic;
using System.Text;
using Problem3CompanyHierarchy.Interfaces;

namespace Problem3CompanyHierarchy.Person.Employee
{
    public class Manager : RegularEmployee, IManager
    {
        private HashSet<Employee> employees; 

        public Manager(string id, string firstName, string lastName, decimal salary, string department, HashSet<RegularEmployee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public HashSet<RegularEmployee> Employees{ get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var employee in this.Employees)
            {
                result.Append(employee + "\n");
            }
            return base.ToString() + $"\n{result}";
        }
    }
}
