using System;

class EvenOddCheck
{
    static void Main()
    {
        // Asking the user to enter a number
        Console.WriteLine("=== Even or Odd Checker ===");
        Console.Write("Please enter a number: ");

        // Reading input as string and converting to integer
        int number = Convert.ToInt32(Console.ReadLine());

        // Checking if the number is even or odd
        if (number % 2 == 0)   // If divisible by 2
        {
            Console.WriteLine("Result: " + number + " is an Even number.");
        }
        else   // Otherwise, it's odd
        {
            Console.WriteLine("Result: " + number + " is an Odd number.");
        }

        // Program end message
        Console.WriteLine("=== Program Finished ===");
    }
};
