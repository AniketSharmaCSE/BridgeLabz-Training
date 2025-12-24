using System;

public class ReverseNumber
{
	static void Main(string[] args)
	{
		//input number from user
		Console.WriteLine("Enter number: ");
		int number = Convert.ToInt32(Console.ReadLine());


		int temp = number;
		int count = 0;

		//count number of digits
		while (temp != 0){
			count++;
			temp /= 10;
		}

		//Initialize digits array
		int[] digits = new int[count];

		//store digits in array
		for (int i = 0; i < count; i++){
			digits[i] = number % 10;
			number /= 10;
		}

		//print reverse
		Console.WriteLine("Reversed number:");
		for (int i = 0; i < digits.Length; i++){
			Console.Write(digits[i]);
		}
	}
}
