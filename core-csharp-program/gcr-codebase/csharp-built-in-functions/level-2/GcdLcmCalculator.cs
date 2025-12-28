using System;

public class GcdLcmCalculator
{
    //Method to calculate GCD
    static int CalculateGcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
	

    //Method to calculate LCM
    static int CalculateLcm(int a, int b)
    {
        return (a * b) / CalculateGcd(a, b);
    }
	
	
	
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

     
        int gcd = CalculateGcd(a, b);
        int lcm = CalculateLcm(a, b);

        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }
}
