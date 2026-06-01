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
int number1 = 440, number2 = 80, result = 0;

// Call the GCD method
result = Utility.GreatestCommonDivisor(number1, number2);

// Print the result to the user
Console.WriteLine($"The GCD of {number1} and {number2} is {result}");

//---------------------------------------------------------------
// End of the Main Method
//---------------------------------------------------------------

//---------------------------------------------------------------
// Start of the Utility Class
//---------------------------------------------------------------

public class Utility
{
    /// <summary>
    /// Calculate the GCD using recursion
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisor(int num1, int num2)
    {
        // Declare and initialize
        int remainder = 0;

        // Base case: num2 is 0
        if (num2 == 0)
        {
            // Return the greatest common divisor
            return num1;
        }
        else
        {
            // Get the remainder of dividing num1 and num2
            remainder = num1 % num2;

            // Print an update to the user
            Console.WriteLine($"Not yet. The remainder of {num1} and {num2} is {remainder}");

            // Call the recursive function of the second number and the remainder
            return GreatestCommonDivisor(num2, remainder);
        }
    }
}

//---------------------------------------------------------------
// End of the Utility Class
//---------------------------------------------------------------