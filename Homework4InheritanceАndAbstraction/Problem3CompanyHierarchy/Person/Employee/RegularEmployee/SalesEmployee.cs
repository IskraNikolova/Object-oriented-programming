
using System.Collections.Generic;
using System.Linq;
using Problem3CompanyHierarchy.Interfaces;

namespace Problem3CompanyHierarchy.Person.Employee
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, string department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            string result = this.Sales.Aggregate(string.Empty, (current, sale) => current + sale);
            return base.ToString() + $"{result}";
        }
    }
}
