using System;

public class NumberCheck
{
	static void Main(string[] args)
	{
		// Declare array to store 5 numbers
		int[] numbers = new int[5];
		
		// Take user input
		Console.WriteLine("Enter 5 numbers:");
		for (int i = 0; i < numbers.Length; i++){
			numbers[i] = Convert.ToInt32(Console.ReadLine());
		}
		

		// Check each number
		for (int i = 0; i < numbers.Length; i++){
			if (numbers[i] == 0){
				Console.WriteLine(numbers[i] + " is zero");
			}
			else if (numbers[i] < 0){
				Console.WriteLine(numbers[i] + " is negative");
			}
			else{
				Console.WriteLine(numbers[i] + " is positive");

				if (numbers[i] % 2 == 0){
					Console.WriteLine("It is even");
				}
				else{
					Console.WriteLine("It is odd");
				}
			}
		}

		
		// Compare first and last elements
		if (numbers[0] == numbers[numbers.Length - 1]){
			Console.WriteLine("First and last elements are equal");
		}
		else if (numbers[0] > numbers[numbers.Length - 1]){
			Console.WriteLine("First element is greater than last element");
		}
		else{
			Console.WriteLine("First element is less than last element");
		}
	}
}
