using System;

public class PrimeChecker
{
	
    //Method to check whether number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
		
        if (IsPrime(number))
        {

            Console.WriteLine("Prime number");

        }

        else
        {
            Console.WriteLine("Not a prime number");
        }
    }
}

