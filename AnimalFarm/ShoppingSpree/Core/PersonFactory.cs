using ShoppingSpree.Models;

namespace ShoppingSpree.Core
{
    public class PersonFactory
    {
        public Person CreatePerson(string data)
        {
            string[] args = data
                .Trim()
                .Split('=');

            return new Person(args[0], double.Parse(args[1]));
        }
    }
}
