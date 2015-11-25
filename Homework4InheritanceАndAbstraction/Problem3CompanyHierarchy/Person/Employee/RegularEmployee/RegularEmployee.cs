
namespace Problem3CompanyHierarchy.Person.Employee
{
    public abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(string id, string firstName, string lastName, decimal salary, string department) 
            : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
