using System;

public class WindChill
{
	//Method to calculate if wind is chilly
	static double CalculateWindChill(double temperature,double windSpeed){
		double windChill=35.74 + 0.6215*temperature + (0.4275*temperature - 35.75)*Math.Pow(windSpeed,0.16);
		return windChill;
		
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter temperature:");
		double temperature=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter wind speed:");
		double windSpeed=Convert.ToDouble(Console.ReadLine());
		double result=CalculateWindChill(temperature,windSpeed);

		//Print the result
		Console.WriteLine("Wind Chill = "+result);
	}
}
