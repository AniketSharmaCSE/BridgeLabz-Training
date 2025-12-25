using System;

public class UnitConverter
{
	//Method to convert kilometers to miles
	static double ConvertKmToMiles(double km){
		return km*0.621371;
	}

	//Method to convert miles to kilometers
	static double ConvertMilesToKm(double miles){
		return miles*1.60934;
	}

	//Method to convert meters to feet
	static double ConvertMetersToFeet(double meters){
		return meters*3.28084;
	}

	//Method to convert feet to meters
	static double ConvertFeetToMeters(double feet){
		return feet*0.3048;
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter kilometers:");
		double km=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter miles:");
		double miles=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter meters:");
		double meters=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter feet:");
		double feet=Convert.ToDouble(Console.ReadLine());

		//Print converted values
		Console.WriteLine("Km to Miles = "+ConvertKmToMiles(km));
		Console.WriteLine("Miles to Km = "+ConvertMilesToKm(miles));
		Console.WriteLine("Meters to Feet = "+ConvertMetersToFeet(meters));
		Console.WriteLine("Feet to Meters = "+ConvertFeetToMeters(feet));
	}
}
