/*
 * Keon Bushman
 * CST - 250
 * 06/07/2026
 * Factorial Recursion
 * Activity 3
 * Activity 3 Guide
 */

//---------------------------------------------------------------
// Start of the Main Method
//---------------------------------------------------------------

// Declare and initialize
using System.Diagnostics;

int number1 = 0, number2 = 0, number3 = 0;
int recursiveResult = 0, iterativeResult = 0, multipleNumberResult = 0;
Stopwatch recursiveStopwatch = new Stopwatch();
Stopwatch iterativeStopwatch = new Stopwatch();

// Prompt the user for the first number
Console.Write("Enter the first number: ");

// Get the users input
number1 = Utility.ReadIntFromConsole();

// Prompt the user for the second number
Console.Write("Enter the second number: ");

// Get the users input
number2 = Utility.ReadIntFromConsole();

// Prompt the user for the third number
Console.Write("Enter the third number: ");

// Get the users input
number3 = Utility.ReadIntFromConsole();

// Start timing the recursive method
recursiveStopwatch.Start();

// Call the recursive GCD method
recursiveResult = Utility.GreatestCommonDivisor(number1, number2);

// Stop timing the recursive method
recursiveStopwatch.Stop();

// Start timing the iterative method
iterativeStopwatch.Start();

// Call the iterative GCD method
iterativeResult = Utility.GreatestCommonDivisorIterative(number1, number2);

// Stop timing the iterative method
iterativeStopwatch.Stop();

// Find the GCD of three numbers
multipleNumberResult = Utility.GreatestCommonDivisor(
    Utility.GreatestCommonDivisor(number1, number2), number3);

// Print the results to the user
Console.WriteLine($"The recursive GCD of {number1} and {number2} is {recursiveResult}");
Console.WriteLine($"The iterative GCD of {number1} and {number2} is {iterativeResult}");
Console.WriteLine($"The GCD of {number1}, {number2}, and {number3} is {multipleNumberResult}");
Console.WriteLine($"Recursive time: {recursiveStopwatch.ElapsedTicks} ticks");
Console.WriteLine($"Iterative time: {iterativeStopwatch.ElapsedTicks} ticks");

//---------------------------------------------------------------
// End of the Main Method
//---------------------------------------------------------------

//---------------------------------------------------------------
// Start of the Utility Class
//---------------------------------------------------------------

public class Utility
{
    /// <summary>
    /// Read an integer from the console
    /// </summary>
    /// <returns></returns>
    internal static int ReadIntFromConsole()
    {
        // Declare and initialize
        int input = 0;
        string inputString = "";

        // Get the users input
        inputString = Console.ReadLine();

        // See if the user entered valid input
        while (!int.TryParse(inputString, out input))
        {
            Console.WriteLine("Invalid number");

            // Re-Prompt the user for a number
            Console.Write("Enter a number: ");

            // Get the users input
            inputString = Console.ReadLine();
        }

        // Return the users input
        return input;
    }

    /// <summary>
    /// Calculate the GCD using recursion
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisor(int num1, int num2)
    {
        // Convert numbers to positive values
        num1 = Math.Abs(num1);
        num2 = Math.Abs(num2);

        // Check if both numbers are 0
        if (num1 == 0 && num2 == 0)
        {
            return 0;
        }

        // Base case: num2 is 0
        if (num2 == 0)
        {
            // Return the greatest common divisor
            return num1;
        }
        else
        {
            // Declare and initialize
            int remainder = 0;

            // Get the remainder of dividing num1 and num2
            remainder = num1 % num2;

            // Print an update to the user
            Console.WriteLine($"Not yet. The remainder of {num1} and {num2} is {remainder}");

            // Call the recursive function of the second number and the remainder
            return GreatestCommonDivisor(num2, remainder);
        }
    }

    /// <summary>
    /// Calculate the GCD using iteration
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisorIterative(int num1, int num2)
    {
        // Convert numbers to positive values
        num1 = Math.Abs(num1);
        num2 = Math.Abs(num2);

        // Declare and initialize
        List<int> num1Divisors = new List<int>();
        List<int> num2Divisors = new List<int>();
        int greatestCommonDivisor = 0;

        // Check if both numbers are 0
        if (num1 == 0 && num2 == 0)
        {
            return 0;
        }

        // Check if the first number is 0
        if (num1 == 0)
        {
            return num2;
        }

        // Check if the second number is 0
        if (num2 == 0)
        {
            return num1;
        }

        // Find the divisors for the first number
        for (int i = 1; i <= num1; i++)
        {
            if ((num1 % i) == 0)
            {
                num1Divisors.Add(i);
            }
        }

        // Find the divisors for the second number
        for (int i = 1; i <= num2; i++)
        {
            if ((num2 % i) == 0)
            {
                num2Divisors.Add(i);
            }
        }

        // Find the largest common divisor
        foreach (int divisor in num1Divisors)
        {
            if (num2Divisors.Contains(divisor))
            {
                greatestCommonDivisor = divisor;
            }
        }

        // Return the greatest common divisor
        return greatestCommonDivisor;
    }
}

//---------------------------------------------------------------
// End of the Utility Class
//---------------------------------------------------------------
