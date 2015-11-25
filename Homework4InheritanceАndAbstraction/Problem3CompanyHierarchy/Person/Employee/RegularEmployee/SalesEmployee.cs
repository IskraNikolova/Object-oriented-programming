
using System.Collections.Generic;

namespace Problem3CompanyHierarchy.Person.Employee
{
    public class SalesEmployee : RegularEmployee
    {
        private HashSet<Sale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, string department, HashSet<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public HashSet<Sale> Sales { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (var sale in this.Sales)
            {
                result += sale;
            }
            return base.ToString() + $"{result}";
        }
    }
}
