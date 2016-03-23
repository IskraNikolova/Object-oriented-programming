
using System.Collections.Generic;
using Problem3CompanyHierarchy.Person.Employee;
using Problem3CompanyHierarchy.Person.Employee.RegularEmployee;

namespace Problem3CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}