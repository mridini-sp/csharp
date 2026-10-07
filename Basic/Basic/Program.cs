using System;
using System.IO;

class Program
{
    static void Main()
    {
        // =====================================================
        // 1. ODD OR EVEN
        // =====================================================

        /*
        // Enter any number here
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check whether number is divisible by 2
        if (n % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
        */


        // =====================================================
        // 2. SWAP TWO NUMBERS
        // =====================================================

        /*
        // Change the values of a and b
        int a = 10;
        int b = 20;

        // Swap without using third variable
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        */


        // =====================================================
        // 3. GREATER AND SMALLER
        // =====================================================

        /*
        // Change the values of a and b
        int a = 10;
        int b = 20;

        if (a > b)
        {
            Console.WriteLine(a + " is greater");
            Console.WriteLine(b + " is smaller");
        }
        else if (b > a)
        {
            Console.WriteLine(b + " is greater");
            Console.WriteLine(a + " is smaller");
        }
        else
        {
            Console.WriteLine("Both are equal");
        }
        */


        // =====================================================
        // 4. PRIME NUMBER
        // =====================================================

        /*
        // Change the number here
        int n = 7;

        bool prime = true;

        // Numbers less than 2 are not prime
        if (n < 2)
            prime = false;

        // Check divisibility
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }
        }

        if (prime)
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not Prime");
        */


        // =====================================================
        // 5. PALINDROME NUMBER
        // =====================================================

        /*
        // Change the number here
        int n = 121;

        int original = n;
        int reverse = 0;

        // Reverse the number
        while (n > 0)
        {
            int digit = n % 10;
            reverse = reverse * 10 + digit;
            n = n / 10;
        }

        // Compare original and reverse
        if (original == reverse)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
        */


        // =====================================================
        // 6. FACTORIAL
        // =====================================================

        /*
        // Change the number here
        int n = 5;

        int fact = 1;

        // Calculate factorial
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine("Factorial = " + fact);
        */


        // =====================================================
        // 7. FIBONACCI SERIES
        // =====================================================

        /*
        // Change number of terms here
        int n = 10;

        int a = 0;
        int b = 1;

        // Print Fibonacci series
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int c = a + b;
            a = b;
            b = c;
        }
        */


        // =====================================================
        // 8. CALCULATOR
        // =====================================================

        /*
        // Change the values of a and b
        int a = 10;
        int b = 5;

        // Addition
        Console.WriteLine("Addition = " + (a + b));

        // Subtraction
        Console.WriteLine("Subtraction = " + (a - b));

        // Multiplication
        Console.WriteLine("Multiplication = " + (a * b));

        // Division
        Console.WriteLine("Division = " + (a / b));
        */


        // =====================================================
        // 9. REVERSE NUMBER
        // =====================================================

        /*
        // Change the number here
        int n = 12345;

        int reverse = 0;

        // Reverse the number
        while (n > 0)
        {
            reverse = reverse * 10 + n % 10;
            n = n / 10;
        }

        Console.WriteLine("Reverse = " + reverse);
        */


        // =====================================================
        // 10. SUM OF DIGITS
        // =====================================================

        /*
        // Change the number here
        int n = 12345;

        int sum = 0;

        // Add each digit
        while (n > 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }

        Console.WriteLine("Sum = " + sum);
        */


        // =====================================================
        // 11. ARMSTRONG NUMBER
        // =====================================================

        /*
        // Change the number here
        int n = 153;

        int original = n;
        int sum = 0;

        // Find cube of each digit
        while (n > 0)
        {
            int digit = n % 10;

            sum = sum + digit * digit * digit;

            n = n / 10;
        }

        // Compare original and sum
        if (original == sum)
            Console.WriteLine("Armstrong");
        else
            Console.WriteLine("Not Armstrong");
        */


        // =====================================================
        // 12. MULTIPLICATION TABLE
        // =====================================================

        /*
        // Change the number here
        int n = 5;

        // Print table from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
        */


        // =====================================================
        // 13. POSITIVE / NEGATIVE / ZERO
        // =====================================================

        /*
        // Change the number here
        int n = -10;

        if (n > 0)
            Console.WriteLine("Positive");
        else if (n < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
        */


        // =====================================================
        // 14. ARRAY
        // =====================================================

        /*
        // Change the array values here
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Display array elements
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        */


        // =====================================================
        // 15. EXCEPTION HANDLING
        // =====================================================

        /*
        try
        {
            // Change the values here
            int a = 10;
            int b = 0;

            // This will cause an exception
            Console.WriteLine(a / b);
        }
        catch
        {
            // This executes when an error occurs
            Console.WriteLine("Cannot divide by zero");
        }
        */


        // =====================================================
        // 16. FILE HANDLING
        // =====================================================

        /*
        // File name
        string file = "test.txt";

        // Write data into file
        File.WriteAllText(file, "Hello C#");

        // Read data from file
        string data = File.ReadAllText(file);

        Console.WriteLine(data);
        */
    }
}



//using System;


// =====================================================
// 1. CLASS AND OBJECT
// =====================================================

/*
class Student
{
    // Change the values here
    public string name = "Mridini";
    public int age = 20;

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Age = " + age);
    }
}

class Program
{
    static void Main()
    {
        // Create object of Student class
        Student s = new Student();

        // Call method using object
        s.Display();
    }
}
*/


// =====================================================
// 2. INHERITANCE
// =====================================================

/*
class Parent
{
    // Parent class method
    public void ShowParent()
    {
        Console.WriteLine("This is Parent Class");
    }
}

class Child : Parent
{
    // Child class method
    public void ShowChild()
    {
        Console.WriteLine("This is Child Class");
    }
}

class Program
{
    static void Main()
    {
        // Create object of Child class
        Child c = new Child();

        // Call parent class method
        c.ShowParent();

        // Call child class method
        c.ShowChild();
    }
}
*/


// =====================================================
// 3. METHOD OVERLOADING
// =====================================================

/*
class Calculator
{
    // Method with 2 parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Same method name with 3 parameters
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        // Create Calculator object
        Calculator c = new Calculator();

        // Call method with 2 arguments
        Console.WriteLine("Sum = " + c.Add(10, 20));

        // Call overloaded method with 3 arguments
        Console.WriteLine("Sum = " + c.Add(10, 20, 30));
    }
}
*/