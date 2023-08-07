using System;

class HelloWorld
{
    static void Sum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!\n");
        Sum(1, 2);
    }
    
}