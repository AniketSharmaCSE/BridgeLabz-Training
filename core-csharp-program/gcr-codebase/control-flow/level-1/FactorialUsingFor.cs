using System;
using System.Numerics;

public class FactorialUsingFor
{
    static void Main(string[] args)
    {
        //input a positive number
        Console.WriteLine("Enter a positive number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        //check if positive
        if (input <= 0)
        {
            Console.WriteLine("Number is not positive");
            return;
        }

        //data type big integer because it can handle larger numbers 
        //Int data type contains only 32 or 64 bits, which fails for larger number
        BigInteger factorial = 1;

        //While loop to calculate factorial
        for (int i = 1; i <= input; i++)
        {
            factorial *= i;
        }
        //print the factorial
        Console.WriteLine(factorial);
    }
}
