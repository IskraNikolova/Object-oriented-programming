namespace Problem3CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using Problem3CompanyHierarchy.Person.Employee;
    using Problem3CompanyHierarchy.Person.Employee.RegularEmployee;

    public class MainTest
    {
        public static void Main()
        {
            Project project1 = new Project("First project", new DateTime(2014, 12, 08), "open");
            project1.CloseProject();

            Project project2 = new Project("Second project", new DateTime(2015, 12, 24), "open");

            Manager manager = new Manager("8109087956", "Iskra", "Radeva", 3000m, "Marketing", 
                new List<Employee>() {
                    new Developer("7710126545", "Ivan", "Mantarov", 1200m, "Marketing",
                    new List<Project>() {project1, project2})
                });
          
            SalesEmployee salesEmployee = new SalesEmployee("8009076545", "Miq", "Nikolova", 2000m, "Sales", 
                new List<Sale>()
                {
                    new Sale("FirstSale", new DateTime(2015, 11, 13), 2200m), new Sale("SecondSale", DateTime.Today, 1358m)
                });
        
            Developer developer = new Developer("56121410000", "Krum", "Tomov", 2400, "Production",
                new List<Project>() {
                    new Project("otherProjectFirst", new DateTime(2013, 08, 21), "closed", "some details"),
                    new Project("OtherProject", new DateTime(2015, 09, 08), "open")
                });

            List<Person.Person> persons = new List<Person.Person>
            {
                manager,
                salesEmployee,
                developer
            };

            foreach (var person in persons)
            {
                Console.WriteLine("___________________________");
                Console.WriteLine(person);
           
            }
        }
    }
}