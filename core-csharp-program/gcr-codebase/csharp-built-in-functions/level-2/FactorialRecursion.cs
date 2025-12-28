using System;

public class FactorialRecursion
{
	
    //Method to calculate factorial using recursion
    static int Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        
		}
        return number * Factorial(number - 1);
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int result = Factorial(number);
        Console.WriteLine("Factorial: " + result);
    }
}
