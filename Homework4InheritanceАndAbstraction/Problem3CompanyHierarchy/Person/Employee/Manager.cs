
using System.Collections.Generic;
using System.Text;
using Problem3CompanyHierarchy.Interfaces;

namespace Problem3CompanyHierarchy.Person.Employee
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees; 

        public Manager(string id, string firstName, string lastName, decimal salary, string department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees{ get; set; }

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
