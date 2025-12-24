using System;

public class SignOfNumber
{
	static void Main(string[] args)
	{
		//Accept a number from user(
		Console.WriteLine("Enter a number: ");
		double number = Convert.ToDouble(Console.ReadLine());

		//Check if positive
		if (number > 0)
		{
			Console.WriteLine("Positive");
		}
		//check if negative
		else if (number < 0)
		{
			Console.WriteLine("Negative");
		}
		//print zero when neither positive nor negative
		else
		{
			Console.WriteLine("zero");
		}
	}
}