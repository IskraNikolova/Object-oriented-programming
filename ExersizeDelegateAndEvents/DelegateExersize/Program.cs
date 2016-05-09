using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateExersize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> towns = new List<string>()
            {
                "Varna",
                "Sofiq",
                "Trqvna",
                "Kazanlyk",
                "Pomorie",
                "Vraca"
            };

            var townWithS = towns.Where(t => t.StartsWith("V"));

            Console.WriteLine(string.Join(", ", townWithS));
        }
    }
}
