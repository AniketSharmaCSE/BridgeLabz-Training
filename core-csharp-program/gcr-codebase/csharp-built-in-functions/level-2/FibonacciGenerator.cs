using System;

public class FibonacciGenerator
{
    //Method to print fibonacci sequence
    static void PrintFibonacci(int terms)
    {

        int first = 0;
        int second = 1;


        for (int i = 1; i <= terms; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
    }
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());    
        PrintFibonacci(terms);
    }
}
