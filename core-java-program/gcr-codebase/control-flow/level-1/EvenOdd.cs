using System;

public class EvenOdd
{
	static void Main(string[] args)
	{
		//ask user for end point
		Console.WriteLine("Enter a number: ");

		int number = Convert.ToInt32(Console.ReadLine());

		//loop from 0 to input number
		for (int i = 0; i <= number; i++)
		{
			//check if even
			if (i % 2 == 0)
			{
				Console.WriteLine(i + " even");
			}
			else
			{
				//if not even, then odd
				Console.WriteLine(i + " odd");
			}
		}
	}
}
