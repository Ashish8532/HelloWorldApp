using System;

class HelloWorld
{
    static void Sum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Multiply(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Multiplication = " + result);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!\n");
        Sum(1, 2);
        Multiply(5, 4);
    }
    
}