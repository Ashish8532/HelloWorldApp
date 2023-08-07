using System;

class HelloWorld
{
    // Method to do Addition of two Numbers
    static void Sum(int a, int b)
    {
        int sum = a + b;
        // Display Summation Result
        Console.WriteLine("Sum = " + sum);
    }

    // Method to do Multiplication of two Numbers
    static void Multiply(int a, int b)
    {
        int result = a * b;
        // Display Multiplication Result 
        Console.WriteLine("Multiplication = " + result);
    }

    // Method to do Division of two Numbers
    static void Division(double x, double y)
    {
        double result = x / y;
        // Display Division Result 
        Console.WriteLine("Division = " + result);
    }

    // Main
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!\n");
        Sum(1, 2); // Calling Sum Method
        Multiply(5, 4); // Calling Multiply Method
        Division(10, 6); // Calling Division Method
    }
    
}