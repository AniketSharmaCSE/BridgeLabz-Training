using System;

public class OddEvenNumbers
{
	static void Main(string[] args)
	{
		//Ask user for input number
		Console.WriteLine("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		//Validate natural number
		if (number <= 0){
			Console.WriteLine("Invalid input");
		}
		

		//Declare arrays for even and odd numbers
		int[] evenNumbers = new int[number / 2 + 1];
		int[] oddNumbers = new int[number / 2 + 1];

		int evenIndex = 0;
		int oddIndex = 0;

		//loop to check even or odd
		for (int i = 1; i <= number; i++){
			if (i % 2 == 0){
				evenNumbers[evenIndex] = i;
				evenIndex++;
			}
			else{
				oddNumbers[oddIndex] = i;
				oddIndex++;
			}
		}

		//Display even numbers
		Console.WriteLine("Even Numbers:");
		for (int i = 0; i < evenIndex; i++){
			Console.Write(evenNumbers[i] + " ");
		}

		//Display odd numbers
		Console.WriteLine("\nOdd Numbers:");
		for (int i = 0; i < oddIndex; i++){
			Console.Write(oddNumbers[i] + " ");
		}
	}
}
