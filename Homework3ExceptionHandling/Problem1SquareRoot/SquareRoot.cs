using System;

public class SquareRoot
{
    public static void Main()
    {
        try
        {
            double inputNumber = double.Parse(Console.ReadLine());
            double squareRoot = Math.Sqrt(inputNumber);
            if (inputNumber < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine(squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

