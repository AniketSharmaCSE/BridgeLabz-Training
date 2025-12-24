using System;

public class DigitCount
{
    static void Main(string[] args)
    {
        //Ask user for the number
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //initialize count variable
        int count = 0;

        //Count digits using while loop
        while (number != 0){
            number = number / 10;
            count++;
        }

        Console.WriteLine("Total digits: " + count);
    }
}
