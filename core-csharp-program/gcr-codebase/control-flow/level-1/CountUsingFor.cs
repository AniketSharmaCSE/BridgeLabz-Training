using System;

public class CountUsingFor
{
    static void Main(string[] args)
    {
        //Ask user for a number
        Console.WriteLine("Enter the start of the count down: ");

        int start = Convert.ToInt32(Console.ReadLine());

        //Create while loop for count down
        for(int i = start; i>=1; i--)
        {

            //print the number
            Console.WriteLine(i);
        }
    }
}
