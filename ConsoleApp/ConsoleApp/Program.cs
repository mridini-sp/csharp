using System;

class SimpleApplication
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to the Simple Application!");

        // Take user's name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Display greeting
        Console.WriteLine("Hello, " + name + "!");

        // Testing the application
        Console.WriteLine("\nTesting the Application...");
        Console.WriteLine("Enter 'quit' to exit.");

        // Repeat until user enters quit
        while (true)
        {
            Console.Write("Enter a number to square: ");
            string input = Console.ReadLine();

            // Exit the loop
            if (input.ToLower() == "quit")
                break;

            // Check whether input is a valid number
            if (int.TryParse(input, out int number))
            {
                // Calculate square
                int result = number * number;

                Console.WriteLine("Square = " + result);
            }
            else
            {
                // Invalid input
                Console.WriteLine("Invalid number!");
            }
        }

        // End message
        Console.WriteLine("Testing complete.");
        Console.ReadKey();
    }
}