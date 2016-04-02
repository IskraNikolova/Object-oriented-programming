using System;
using System.Collections.Generic;
using ObjectStateValidator;

namespace TestValidator
{
    public class Program
    {
        public static void Main()
        {
            var student = new Student()
            {
                FirstName = "Pesho",  
                Age = 31,
                Marks = new List<int>() {4, 2, 6},
                Mentor =
                    new Student()
                    {
                        FirstName = "Gosho",                    
                        Age = 18,
                        Marks = new List<int>() {6, 6, 6}
                    }
            };

            var studentValidator = new Validator(student);
            studentValidator.Validate();

            if (!studentValidator.IsValid)
            {
                foreach (var error in studentValidator.Errors)
                {                  
                    foreach (var errorMassage in error.Value)
                    {
                        Console.WriteLine(errorMassage);
                    }
                }
            }
        }
    }
}
