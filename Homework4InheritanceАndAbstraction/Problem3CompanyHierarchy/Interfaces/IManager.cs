using System.Collections.Generic;
using Problem3CompanyHierarchy.Person.Employee;

namespace Problem3CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}