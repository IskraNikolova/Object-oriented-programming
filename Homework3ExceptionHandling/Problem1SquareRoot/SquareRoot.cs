namespace Problem1SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            try
            {
                double inputNumber = double.Parse(Console.ReadLine());

                if (inputNumber < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double squareRoot = Math.Sqrt(inputNumber);

                Console.WriteLine($"Square root is {squareRoot}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArithmeticException ax)
            {
                Console.WriteLine(ax.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}