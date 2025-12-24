using System;

public class SalaryBonus
{
	static void Main(string[] args)
	{
		//Input salary and years of service
		Console.WriteLine("Enter your Salary: ");
		double salary = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter years of service: ");
        double years = Convert.ToDouble(Console.ReadLine());

		//Check if years less than five
		if (years < 5)
		{
			Console.WriteLine("Not eligible for bonus!");
		}
		else {
			//Calculate and print bonus amount
			double bonus = salary / 100 * 5;
			Console.WriteLine("Your bonus amount is: " + bonus);
		}
    }
}
