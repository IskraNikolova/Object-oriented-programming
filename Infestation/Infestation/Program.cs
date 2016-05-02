using System;

namespace Infestation
{
    public class Program
    {
        public static void Main()
        {
            HoldingPen pen = InitializePen();
            StartOperations(pen);
        }

        private static void StartOperations(HoldingPen pen)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                pen.ParseCommand(input);
                input = Console.ReadLine();
            }
        }

        private static HoldingPen InitializePen()
        {
            return new ExtendingHoldingPen();
        }
    }
}
