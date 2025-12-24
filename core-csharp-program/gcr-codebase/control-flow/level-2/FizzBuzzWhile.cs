using System;

public class FizzBuzzWhile
{
    static void Main(string[] args)
    {
        //Ask user for a end point
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 1;


        //While loop to traverse till end point
        while (i <= number)
        {
            //Condition to check where to print 
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }

            i++;
        }
    }
}
