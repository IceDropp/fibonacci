using System;

class FibonacciWithRecursion
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of terms in Fibonacci series: ");
        int terms = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series (with recursion):");
        for (int i = 0; i < terms; i++)
        {
            Console.WriteLine();
            Console.Write(Fibonacci(i) + " " );
        }
        Console.WriteLine();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
