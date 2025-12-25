using System;

public class UnitConverterExtended
{
	//Method to convert yards to feet
	static double ConvertYardsToFeet(double yards){
		return yards*3;
	}

	//Method to convert feet to yards
	static double ConvertFeetToYards(double feet){
		return feet*0.333333;
	}

	//Method to convert meters to inches
	static double ConvertMetersToInches(double meters){
		return meters*39.3701;
	}

	//Method to convert inches to meters
	static double ConvertInchesToMeters(double inches){
		return inches*0.0254;
	}

	//Method to convert inches to centimeters
	static double ConvertInchesToCentimeters(double inches){
		return inches*2.54;
	}
	

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter yards:");
		double yards=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter feet:");
		double feet=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter meters:");
		double meters=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter inches:");
		double inches=Convert.ToDouble(Console.ReadLine());

		//Print converted values
		Console.WriteLine("Yards to Feet = "+ConvertYardsToFeet(yards));
		Console.WriteLine("Feet to Yards = "+ConvertFeetToYards(feet));
		Console.WriteLine("Meters to Inches = "+ConvertMetersToInches(meters));
		Console.WriteLine("Inches to Meters = "+ConvertInchesToMeters(inches));
		Console.WriteLine("Inches to Centimeters = "+ConvertInchesToCentimeters(inches));
	}
}
