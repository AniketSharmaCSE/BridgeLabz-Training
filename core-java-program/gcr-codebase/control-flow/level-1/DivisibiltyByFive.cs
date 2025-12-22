using System;

public class DivisilityByFive
{
	static void Main(string[] args)
	{
		//ask user for a number
		Console.WriteLine("Enter a number: ");
		double num = Convert.ToDouble(Console.ReadLine());

		//Check if divisible by 5
		if (num % 5 == 0)
		{
			//print is divisible
			Console.WriteLine(num + " is divisible by 5");
		}
			//print not divisible
		else {
            Console.WriteLine(num + " is not divisible by 5");
        }
	}
}
