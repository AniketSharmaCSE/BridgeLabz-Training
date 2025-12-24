using System;

public class DynamicLargestDigits
{
	static void Main(string[] args)
	{
		//input number from user
		Console.WriteLine("Enter number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		int maxDigit = 10;
		int[] digits = new int[maxDigit];
		int index = 0;


		//store digits in array
		while (number != 0){
			if (index == maxDigit){
				maxDigit += 10;
				int[] temp = new int[maxDigit];

				for (int i = 0; i < digits.Length; i++)
					temp[i] = digits[i];

				digits = temp;
			}

			digits[index] = number % 10;
			number = number / 10;
			index++;
		}

		int largest = 0;
		int secondLargest = 0;

		//find largest and second largest
		for (int i = 0; i < index; i++){
			if (digits[i] > largest){
				secondLargest = largest;
				largest = digits[i];
			}
			else if (digits[i] > secondLargest && digits[i] != largest){
				secondLargest = digits[i];
			}
		}

		//print the result
		Console.WriteLine("Largest = " + largest);
		Console.WriteLine("Second Largest = " + secondLargest);
	}
}
