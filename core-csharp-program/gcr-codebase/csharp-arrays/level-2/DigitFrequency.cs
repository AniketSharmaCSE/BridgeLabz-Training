using System;

public class DigitFrequency
{
	static void Main(string[] args)
	{
		//input number from user
		Console.WriteLine("Enter number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		//declare variable for temporary number and count
		int temp = number;
		int count = 0;

		//count digits using while loop
		while (temp != 0)
		{
			count++;
			temp /= 10;
		}
		
		//initialize arrays for digits and frequency
		int[] digits = new int[count];
		int[] freq = new int[10];

		//store digits in array
		for (int i = 0; i < count; i++){
			digits[i] = number % 10;
			number /= 10;
		}

		//count frequency of digit
		for (int i = 0; i < digits.Length; i++){
			freq[digits[i]]++;
		}

		//display frequency
		for (int i = 0; i < freq.Length; i++){
			if (freq[i] > 0)
				Console.WriteLine(i + " = " + freq[i]);
		}
	}
}
