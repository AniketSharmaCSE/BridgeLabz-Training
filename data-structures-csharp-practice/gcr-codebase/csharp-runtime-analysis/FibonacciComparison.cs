using System;
using System.Diagnostics;

class FibonacciComparison
{
    //Recursive Fibonacci method
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
	

    //Iterative Fibonacci method
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0;
        int b = 1;
        int sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }


    static void Main(string[] args)
    {
        int n = 30;
        Stopwatch sw = new Stopwatch();

        //Recursive Fibonacci time
        sw.Start();
        int r1 = FibonacciRecursive(n);
        sw.Stop();
        Console.WriteLine("Recursive Fibonacci Result: " + r1);
        Console.WriteLine("Recursive Time: " + sw.ElapsedMilliseconds + " ms");

        //Iterative Fibonacci time
        sw.Reset();
        sw.Start();
        int r2 = FibonacciIterative(n);
        sw.Stop();
        Console.WriteLine("Iterative Fibonacci Result: " + r2);
        Console.WriteLine("Iterative Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
