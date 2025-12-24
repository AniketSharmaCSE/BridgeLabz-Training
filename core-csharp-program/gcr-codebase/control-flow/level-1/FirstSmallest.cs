using System;

public class FirstSmallest
{
    static void Main(string[] args)
    {
        //Take input for all three numbers
        Console.WriteLine("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double third = Convert.ToDouble(Console.ReadLine());

        if (first < second && first < third)
        {
            Console.WriteLine("First is the smallest number");

        }
        else
        {
            Console.WriteLine("First is not the smallest");
        }
    }
}
