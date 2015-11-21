using System;

namespace Exercise3ExceptionHandling
{
    public class MainTest
    {
        public static void Main()
        {
            try
            {
                  Person unNamed = new Person(string.Empty, "SecondName", 31);
               // Person negativeAge = new Person("Pesho", "SecondName", -32);
               // Person unNamedSecond = new Person("FirstName", string.Empty, 31);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
        }
    }
}
