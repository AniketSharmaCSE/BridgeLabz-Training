using System;

public class TableSixToNine
{
	static void Main(string[] args)
	{
		//Ask user for input number
		Console.WriteLine("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		//Declare array to store results
		int[] multiplicationResult = new int[4];

		//Index for array
		int index = 0;

		//Store multiplication results from 6 to 9
		for (int i = 6; i <= 9; i++){
			multiplicationResult[index] = number * i;
			index++;
		}

		//print the table
		index = 0;
		for (int i = 6; i <= 9; i++){
			Console.WriteLine(number + " * " + i + " = " + multiplicationResult[index]);
			index++;
		}
	}
}
