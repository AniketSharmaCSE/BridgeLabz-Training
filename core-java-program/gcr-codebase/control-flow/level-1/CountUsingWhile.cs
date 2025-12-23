using System;

public class CountUsingWhile
{
	static void Main(string[] args)
	{
		//Ask user for a number
		Console.WriteLine("Enter the start of the count down: ");
		
		int start = Convert.ToInt32(Console.ReadLine());

		//Create while loop for count down
		while (start != 1) {
			
			//print the number
			Console.WriteLine(start);
            //decrement the number
            start--;
        }
	}
}
