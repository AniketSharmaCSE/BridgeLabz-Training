using System;

public class FizzBuzz
{
	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter a number:");
		int number = Convert.ToInt32(Console.ReadLine());

		//Create string array
		string[] result = new string[number + 1];

		//Store values in array
		for (int i = 1; i <= number; i++){
			if (i % 3 == 0 && i % 5 == 0){
				result[i] = "FizzBuzz";
			}
			else if (i % 3 == 0){
				result[i] = "Fizz";
			}
			else if (i % 5 == 0){
				result[i] = "Buzz";
			}
			else{
				result[i] = i.ToString();
			}
		}

		// Print result
		for (int i = 1; i <= number; i++){
			Console.WriteLine("Position " + i + " = " + result[i]);
		}
	}
}
