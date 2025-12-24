using System;

public class VoteEligibility
{
	static void Main(string[] args)
	{
		//Ask user for their age
		Console.WriteLine("Enter your age: ");
		int age = Convert.ToInt32(Console.ReadLine());

		//Check if above or equal to 18
		if (age >= 18)
		{
			//print if eligible
			Console.WriteLine("The person's age is: " + age + " and can vote");
		}
		else {
			//print if not eligible
            Console.WriteLine("The person's age is: " + age + " and cannot vote");
        }
	}
}
