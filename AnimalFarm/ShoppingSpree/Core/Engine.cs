using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingSpree.Models;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private readonly PersonFactory personFactory;
        private readonly ProductFactory productFactory;
        private readonly IList<Person> persons;
        private readonly IList<Product> products;

        public Engine()
        {
            this.personFactory = new PersonFactory();
            this.productFactory = new ProductFactory();
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                string[] personsA = Console.ReadLine()
                    .Trim()
                    .Split(';');

                foreach (var personData in personsA)
                {
                    Person person = this.personFactory.CreatePerson(personData);
                    this.persons.Add(person);
                }

                string[] productCoolection = Console.ReadLine()
                    .Trim()
                    .TrimEnd(';')
                    .Split(';');

                foreach (var productData in productCoolection)
                {
                    Product product = this.productFactory.CreateProduct(productData);
                    this.products.Add(product);
                }

                string command = Console.ReadLine().Trim();
                while (command != "END")
                {
                    string[] commandArgs = command.Split();
                    string personName = commandArgs[0];
                    string productName = commandArgs[1];
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);

                    this.persons.First(p => p.Name == personName).AddProduct(product);

                    command = Console.ReadLine().Trim();
                }

                foreach (var person in this.persons)
                {
                    string products =
                        person.Products.Count >= 1 ? string.Join(", ", person.Products) : "Nothing bought";
                    Console.WriteLine($"{person.Name} - {products}");
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }     
        }
    }
}
