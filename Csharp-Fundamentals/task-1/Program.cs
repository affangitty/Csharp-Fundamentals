using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        string input = Console.ReadLine();

        // Validate input
        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        long result = Factorial(number);

        Console.WriteLine($"Factorial of {number} is {result}");
    }

    // Method to calculate factorial
    static long Factorial(int n)
    {
        long fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        return fact;
    }

    // recursion
    // static long Factorial(int n)
    // {
    //     if (n == 0 || n == 1) return 1;
    //     return n * Factorial(n - 1);
    // }
}