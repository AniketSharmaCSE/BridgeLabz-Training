using System;

public class EmployeeBonus
{
	static void Main(string[] args)
	{
		//arrays for salary and years
		double[] salary = new double[10];
		double[] years = new double[10];
		double[] bonus = new double[10];
		double[] newSalary = new double[10];

		double totalBonus = 0;
		double totalOldSalary = 0;
		double totalNewSalary = 0;


		//take input from user
		for (int i = 0; i < salary.Length; i++){
			Console.WriteLine("Enter salary:");
			salary[i] = Convert.ToDouble(Console.ReadLine());


			Console.WriteLine("Enter years of service:");
			years[i] = Convert.ToDouble(Console.ReadLine());

			if (salary[i] < 0 || years[i] < 0){
				i--;
			}
		}


		//calculate bonus using for loop
		for (int i = 0; i < salary.Length; i++){
			if (years[i] > 5){
				bonus[i] = salary[i] * 0.05;
			}
			else{
				bonus[i] = salary[i] * 0.02;
			}

			newSalary[i] = salary[i] + bonus[i];
			totalBonus += bonus[i];
			totalOldSalary += salary[i];
			totalNewSalary += newSalary[i];
		}

		Console.WriteLine("Total Bonus = " + totalBonus);
		Console.WriteLine("Total Old Salary = " + totalOldSalary);
		Console.WriteLine("Total New Salary = " + totalNewSalary);
	}
}
