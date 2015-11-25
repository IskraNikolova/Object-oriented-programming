
using System.Collections.Generic;
using System.Linq;
using Problem3CompanyHierarchy.Interfaces;

namespace Problem3CompanyHierarchy.Person.Employee
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private HashSet<Project> projects;
        public Developer(string id, string firstName, string lastName, decimal salary, string department, HashSet<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public HashSet<Project> Projects { get; set; }

        public override string ToString()
        {
            string result = this.Projects.Aggregate(string.Empty, (current, project) => current + (project + "\n"));
            return base.ToString() + $"{result}";
        }
    }
}
