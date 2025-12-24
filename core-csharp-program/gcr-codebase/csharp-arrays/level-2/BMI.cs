using System;

public class BMI
{
	static void Main(string[] args)
	{
		//Take input for number of persons
		Console.WriteLine("Enter number of persons:");
		int n = Convert.ToInt32(Console.ReadLine());

		double[] weight = new double[n];
		double[] height = new double[n];
		double[] bmi = new double[n];
		string[] status = new string[n];


		//Take input for weight and height
		for (int i = 0; i < n; i++){
			Console.WriteLine("Enter weight:");
			weight[i] = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter height:");
			height[i] = Convert.ToDouble(Console.ReadLine());

			//calculate BMI
			bmi[i] = weight[i] / (height[i] * height[i]);

			if (bmi[i] < 18.5)
				status[i] = "Underweight";
			else if (bmi[i] < 25)
				status[i] = "Normal";
			else
				status[i] = "Overweight";
		}

		//print results
		for (int i = 0; i < n; i++){
			Console.WriteLine(height[i] + " " + weight[i] + " " + bmi[i] + " " + status[i]);
		}
	}
}
