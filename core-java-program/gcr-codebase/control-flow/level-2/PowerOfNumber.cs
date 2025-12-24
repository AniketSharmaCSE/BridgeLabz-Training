using System;

public class PowerOfNumber
{
    static void Main(string[] args)
    {
        //Ask user for number and power
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        //For loop to calculate power
        for (int i = 1; i <= power; i++){
            result = result * number;
        }

        //print the result
        Console.WriteLine("Result is: " + result);
    }
}
