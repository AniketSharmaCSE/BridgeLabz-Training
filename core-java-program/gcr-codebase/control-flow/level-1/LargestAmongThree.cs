using System;

public class LargestAmongThree
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

        //Variable to store largest number
        double largest = 0;

        //Conditions to find largest among three
        if (first > second && first > third)
        {
            largest = first;
        }
        else if (second > third && second > first)
        {
            largest = second;

        }
        else
        {
            largest = third;
        }

        //print the largest number 
        Console.WriteLine("The largest number is: " + largest);
    }
}
