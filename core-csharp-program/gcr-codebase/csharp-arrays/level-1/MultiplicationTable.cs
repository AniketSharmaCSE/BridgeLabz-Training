using System;

public class MultiplicationTable
{
	static void Main(string[] args)
	{
		//Ask user for the number
		Console.WriteLine("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		//create array for table
		int[] table = new int[10];

		//for loop to calculate multiples
		for (int i = 0; i < table.Length; i++){
			table[i] = number * (i + 1);
		}
		
		
		//print the result
		for (int i = 0; i < table.Length; i++){
			Console.WriteLine(number + " * " + (i + 1) + " = " + table[i]);
		}
	}
}
