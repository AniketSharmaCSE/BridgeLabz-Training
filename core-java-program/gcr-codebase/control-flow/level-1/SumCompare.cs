using System;

public class SumCompare
{
	static void Main(string[] args)
	{
		//ask user for a number
		Console.WriteLine("Enter a natural number: ");
		int input = Convert.ToInt32(Console.ReadLine());

		//variable for storing sum
		int TotalFormula=0;
		int TotalWhile=0;

		//Check if number is natural number
		if (input <= 0) {
			Console.WriteLine(input + " is not a natural number");
		}
		else {

			TotalFormula = input * (input + 1) / 2;

			while (input > 0) {
				TotalWhile += input;
				input--;
			}
		}
		//Print and compare result
		Console.WriteLine("Sum by formula is: "+TotalFormula);
		Console.WriteLine("Sum by while loop is: "+TotalWhile);
		Console.WriteLine("Are they both equal? "+ (TotalWhile==TotalFormula));
	}
}
