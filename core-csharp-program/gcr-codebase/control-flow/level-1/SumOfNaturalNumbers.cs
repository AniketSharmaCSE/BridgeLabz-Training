using System;

public class SumOfNaturalNumbers
{
	static void Main(string[] args)
	{
		//Ask user for a number
		Console.WriteLine("Enter a number: ");
		double num = Convert.ToDouble(Console.ReadLine());

		//Check if not natural number
		if (num <= 0)
		{
			Console.WriteLine(num + " is not a natural number");
		}
		else {
			//if natural number, calculate sum
			double sum = num * (num + 1) / 2;
			//print the sum
			Console.WriteLine("The sum of " + num + " natural numbers is " + sum);
		}
	}
}
