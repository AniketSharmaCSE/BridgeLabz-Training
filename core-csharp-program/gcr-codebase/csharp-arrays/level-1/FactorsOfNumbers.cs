using System;

public class FactorsOfNumber
{
	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter a number:");
		int number = Convert.ToInt32(Console.ReadLine());

		//Declare Array to store factors
		int[] factors = new int[number];
		int index = 0;

		//For loop to find factors of the number
		for (int i = 1; i <= number; i++){
			if (number % i == 0){
				factors[index] = i;
				index++;
			}
		}

		//Print the factors
		Console.WriteLine("Factors are:");
		for (int i = 0; i < index; i++){
			Console.Write(factors[i] + " ");
		}
	}
}
