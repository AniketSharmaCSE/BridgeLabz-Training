using System;

public class BMI2D
{
	static void Main(string[] args)
	{
		//Take input for number of persons
		Console.WriteLine("Enter number of persons:");
		int n = Convert.ToInt32(Console.ReadLine());

		//declare 2D array
		double[][] personData = new double[n][];
		string[] status = new string[n];

		for (int i = 0; i < n; i++){
			personData[i] = new double[3];
		}
		
		for (int i = 0; i < n; i++){
			Console.WriteLine("Enter weight:");
			personData[i][0] = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter height:");
			personData[i][1] = Convert.ToDouble(Console.ReadLine());

			//Calculate BMI
			personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);

			if (personData[i][2] < 18.5)
				status[i] = "Underweight";
			else if (personData[i][2] < 25)
				status[i] = "Normal";
			else
				status[i] = "Overweight";
		}

		//print the result
		for (int i = 0; i < n; i++){
			Console.WriteLine(personData[i][1] + " " + personData[i][0] + " " + personData[i][2] + " " + status[i]);
		}
	}
}
