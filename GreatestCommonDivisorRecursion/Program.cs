using System;

Console.WriteLine("GCD Algorithm Calculator");
Console.WriteLine("------------------------");

int number1 = ReadInteger("Enter the first integer: ");
int number2 = ReadInteger("Enter the second integer: ");
int number3 = ReadInteger("Enter the third integer: ");

int recursiveSteps = 0;
int iterativeSteps = 0;

long recursiveResult = GreatestCommonDivisorRecursive(number1, number2, ref recursiveSteps);
long iterativeResult = GreatestCommonDivisorIterative(number1, number2, ref iterativeSteps);
long threeNumberResult = GreatestCommonDivisorRecursive(
    GreatestCommonDivisorRecursive(number1, number2),
    number3);

Console.WriteLine();
Console.WriteLine($"Recursive GCD of {number1} and {number2}: {recursiveResult}");
Console.WriteLine($"Recursive Euclidean steps: {recursiveSteps}");
Console.WriteLine();
Console.WriteLine($"Iterative GCD of {number1} and {number2}: {iterativeResult}");
Console.WriteLine($"Iterative Euclidean steps: {iterativeSteps}");
Console.WriteLine();
Console.WriteLine($"Results match: {recursiveResult == iterativeResult}");
Console.WriteLine($"GCD of {number1}, {number2}, and {number3}: {threeNumberResult}");

static int ReadInteger(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int value))
        {
            return value;
        }

        Console.WriteLine("Please enter a valid whole number.");
    }
}

static long GreatestCommonDivisorRecursive(int first, int second, ref int steps)
{
    return GreatestCommonDivisorRecursive(Normalize(first), Normalize(second), ref steps);
}

static long GreatestCommonDivisorRecursive(int first, int second)
{
    int unusedSteps = 0;
    return GreatestCommonDivisorRecursive(first, second, ref unusedSteps);
}

static long GreatestCommonDivisorRecursive(long first, int second)
{
    int unusedSteps = 0;
    return GreatestCommonDivisorRecursive(first, Normalize(second), ref unusedSteps);
}

static long GreatestCommonDivisorRecursive(long first, long second, ref int steps)
{
    if (second == 0)
    {
        return first;
    }

    steps++;
    return GreatestCommonDivisorRecursive(second, first % second, ref steps);
}

static long GreatestCommonDivisorIterative(int first, int second, ref int steps)
{
    long a = Normalize(first);
    long b = Normalize(second);

    while (b != 0)
    {
        long remainder = a % b;
        a = b;
        b = remainder;
        steps++;
    }

    return a;
}

static long Normalize(int value)
{
    // Convert to long before taking the absolute value so int.MinValue is safe.
    return Math.Abs((long)value);
}
