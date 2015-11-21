using System;
using System.Collections.Generic;
using System.Linq;

public class EnterNumbers
{
    private const int Count = 10;
    private const int MinNumber = 1;
    private const int MaxNumber = 100;

    private static List<int> result; 
    public static void Main()
    {
        result = new List<int>();
        while (result.Count < Count)
        {
            try
            {
                int number = ReadNumber(MinNumber, MaxNumber);
                int number2 = ReadNumber(result[result.Count - 1], MaxNumber);
                result.Add(!result.Any() ? number : number2);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number must be in range[1...100]");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!Try again!");
            }
        }
        
        Console.WriteLine(string.Join(", ", result));      
    }

    public static int ReadNumber(int start, int end)
    {
        Console.Write("Enter a number in range [{0}...{1}] ", start + 1, end - 1);
        int number = int.Parse(Console.ReadLine());
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException($"Number must be in range[{start + 1}...{end - 1}]");
        }
        return number;
    }
}

