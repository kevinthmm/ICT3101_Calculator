// See https://aka.ms/new-console-template for more information
namespace ICT3101_Calculator;

internal abstract class Program
{
    private static void Main()
    {
        bool endApp = false;
        Calculator calculator = new Calculator();
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");
        while (!endApp)
        {
            // Declare variables and set to empty.
            // Ask the user to type the first number.
            Console.Write("Type a number, and then press Enter: ");
            var numInput1 = Console.ReadLine();
            double cleanNum1;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput1 = Console.ReadLine();
            }
            // Ask the user to type the second number.
            Console.Write("Type another number, and then press Enter: ");
            var numInput2 = Console.ReadLine();
            double cleanNum2;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput2 = Console.ReadLine();
            }
            // Ask the user to type the third number.
            Console.Write("Type another number, and then press Enter: ");
            var numInput3 = Console.ReadLine();
            double cleanNum3;
            while (!double.TryParse(numInput3, out cleanNum3))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput3 = Console.ReadLine();
            }
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add: add num1 and num2");
            Console.WriteLine("\ts - Subtract: num1 - num2");
            Console.WriteLine("\tm - Multiply num1 * num2");
            Console.WriteLine("\td - Divide: num1 / num2");
            Console.WriteLine("\tf - FactorialP: num1!");
            Console.WriteLine("\tMTBF - Mean Time Before Failure: Using num1 and num2");
            Console.WriteLine("\tAvail - Availability: Using num1 and num2");
            Console.WriteLine("\tCFIB - Current Failure Intensity BASIC: Using num1(l0), num2(\ud835\udf07), and num3(\ud835\udc630)");
            Console.WriteLine("\tANEFB - Average Number of Expected Failures BASIC: Using num1(\ud835\udc630), num2(l0), and num3(t)");
            Console.WriteLine("\tDD - Defect Defect Density (def/KLOC): Using num1 as defects, num2 as Number of KSSI in KLOC ");
            Console.WriteLine("\tSSI - KSSI (current): Using num1 as OLD KSSI in KLOC, num2 as New KSSI, and num3 as changed/deleted KSSI ");
            Console.WriteLine("\tCFIL - Current Failure Intensity LOG: Using num1(l0), num2(DelayParam), and num3(\ud835\udc630)");
            Console.WriteLine("\tANEFL - Average Number of Expected Failures LOG: Using num1(l0), num2(decayParam), and num3(t)");
            Console.Write("Your option? ");
            string? op = Console.ReadLine();
            try
            {
                var result = calculator.DoOperation(cleanNum1, cleanNum2, cleanNum3, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying math.\n - Details: " + e.Message);
            }
            Console.WriteLine("------------------------\n");
            // Wait for the user to respond before closing.
            Console.Write("Press 'q' and Enter to quit the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "q") endApp = true;
            Console.WriteLine("\n"); // Friendly line spacing.
        }
    }
}
