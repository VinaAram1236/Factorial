using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Factorial Calculator");
        Console.WriteLine();
        Console.WriteLine("Rule:");
        Console.WriteLine("A factorial is found by multiplying");
        Console.WriteLine("a whole number by every whole number");
        Console.WriteLine("below it until 1.");
        Console.WriteLine("Example: 5! = 5 × 4 × 3 × 2 × 1 = 120");
        Console.WriteLine();

        Console.Write("Enter a whole number (0 to 20): ");

        int number;

        while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 20)
        {
            Console.WriteLine("Invalid input! Please enter a whole number between 0 and 20.");
            Console.Write("Enter a whole number: ");
        }

        long factorial = 1;

        Console.WriteLine();
        Console.Write("Explanation: ");

        if (number == 0)
        {
            Console.WriteLine("0! = 1");
        }
        else
        {
            for (int i = number; i >= 1; i--)
            {
                Console.Write(i);

                if (i > 1)
                {
                    Console.Write(" × ");
                }

                factorial *= i;
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine(number + "! = " + factorial);
        Console.WriteLine();
        Console.WriteLine("The factorial of " + number + " is " + factorial + ".");

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}