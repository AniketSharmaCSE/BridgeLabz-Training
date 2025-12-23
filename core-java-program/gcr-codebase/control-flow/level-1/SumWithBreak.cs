using System;

public class SumWithBreak
{
	static void Main(string[] args)
	{	
		//Declare and initialies variables to store sum and input value
		double total = 0;
		double input = 1;

		while (true)
		{
			//ask user for input
			Console.WriteLine("Enter a number to add");
			Console.WriteLine("Enter zero or negative number to exit: ");
			input = Convert.ToDouble(Console.ReadLine());

			//Check and break loop if input 0 or negative
			if (input == 0 || input < 0)
			{
				break;
			}
			total += input;

		}
		//print the total
		Console.WriteLine("The total is: " + total);
	}
}

