using System;

public class MaximumOfThree
{
    //Method to find maximum of three numbers
    static int FindMaximum(int a, int b, int c)
    {
        int max = a;
        if (b > max)
        {
            max = b;
        }
		
		
        if (c > max)
        {
            max = c;
        }

        return max;
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        
        int result = FindMaximum(a, b, c);

        Console.WriteLine("Maximum number: " + result);
    }
}
