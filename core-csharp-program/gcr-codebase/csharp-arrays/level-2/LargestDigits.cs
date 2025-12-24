using System;

public class LargestDigits
{
	static void Main(string[] args)
	{
		//input number from user
		Console.WriteLine("Enter number:");
		int number = Convert.ToInt32(Console.ReadLine());

		int maxDigit = 10;
		int[] digits = new int[maxDigit];
		int index = 0;

		//store digits in array
		while (number != 0 && index < maxDigit){
			digits[index] = number % 10;
			number = number / 10;
			index++;
		}

		int largest = 0;
		int secondLargest = 0;

		//find largest digit
		for (int i = 0; i < index; i++){
			if (digits[i] > largest){
				secondLargest = largest;
				largest = digits[i];
			}
			else if (digits[i] > secondLargest && digits[i] != largest){
				secondLargest = digits[i];
			}
		}

		Console.WriteLine("Largest = " + largest);
		Console.WriteLine("Second Largest = " + secondLargest);
	}
}
