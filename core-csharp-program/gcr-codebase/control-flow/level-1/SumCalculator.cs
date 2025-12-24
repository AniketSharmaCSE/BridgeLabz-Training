using System;

public class SumCalculator
{
	static void Main(string[] args)
	{
		//Variable to store the sum and store input
		double total = 0;
		double input = 1;
		
		//While loop to add until input 0
		while (input != 0) {
            //Ask user to either enter number for sum, or enter 0 to exit
            Console.WriteLine("Enter a number to add or enter zero to exit: ");
            input = Convert.ToDouble(Console.ReadLine());

			//add to the total
            total += input;
		}
		//print the total
		Console.WriteLine("The total is: "+total);
	}
}
