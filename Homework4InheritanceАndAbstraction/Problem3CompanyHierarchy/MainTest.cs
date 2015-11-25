using System;
using System.Collections.Generic;
using Problem3CompanyHierarchy.Person.Employee;

public class MainTest
{
    public static void Main()
    {
        Manager manager = new Manager("8109087956", "Iskra", "Radeva", 3000m, "Marketing", 
            new HashSet<RegularEmployee>() {new Developer("7710126545", "Ivan", "Mantarov", 1200m, "Marketing",
            new HashSet<Project>() {new Project("NewProject", new DateTime(2015, 12, 24), "open")})
            });
   
        SalesEmployee salesEmployee = new SalesEmployee("8009076545", "Miq", "Nikolova", 2000m, "Sales", 
            new HashSet<Sale>() {new Sale("FirstSale", new DateTime(2015, 11, 13), 2200m), new Sale("SecondSale", DateTime.Today, 1358m)});
        
        Developer developer = new Developer("56121410000", "Krum", "Tomov", 2400, "Production",
            new HashSet<Project>() {new Project("otherProjectFirst", new DateTime(2013, 08, 21), "closed", "some details"),
                new Project("OtherProject", new DateTime(2015, 09, 08), "open")});

        List<Person> persons = new List<Person>();
        persons.Add(manager);
        persons.Add(salesEmployee);
        persons.Add(developer);

        foreach (var person in persons)
        {
            Console.WriteLine("___________________________");
            Console.WriteLine(person);
           
        }
    }
}

