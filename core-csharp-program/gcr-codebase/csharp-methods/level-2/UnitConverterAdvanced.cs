using System;

public class UnitConverterAdvanced
{
	//Method to convert fahrenheit to celsius
	static double ConvertFahrenheitToCelsius(double f){
		return (f-32)*5/9;
	}

	//Method to convert celsius to fahrenheit
	static double ConvertCelsiusToFahrenheit(double c){
		return (c*9/5)+32;
	}

	//Method to convert pounds to kilograms
	static double ConvertPoundsToKilograms(double p){
		return p*0.453592;
	}

	//Method to convert kilograms to pounds
	static double ConvertKilogramsToPounds(double kg){
		return kg*2.20462;
	}

	//Method to convert gallons to liters
	static double ConvertGallonsToLiters(double g){
		return g*3.78541;
	}

	//Method to convert liters to gallons
	static double ConvertLitersToGallons(double l){
		return l*0.264172;
	}
	
	

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter temperature in Fahrenheit:");
		double f=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter temperature in Celsius:");
		double c=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter weight in pounds:");
		double p=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter weight in kilograms:");
		double kg=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter gallons:");
		double g=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter liters:");
		double l=Convert.ToDouble(Console.ReadLine());


		//Print converted values
		Console.WriteLine("F to C = "+ConvertFahrenheitToCelsius(f));
		Console.WriteLine("C to F = "+ConvertCelsiusToFahrenheit(c));
		Console.WriteLine("Pounds to Kg = "+ConvertPoundsToKilograms(p));
		Console.WriteLine("Kg to Pounds = "+ConvertKilogramsToPounds(kg));
		Console.WriteLine("Gallons to Liters = "+ConvertGallonsToLiters(g));
		Console.WriteLine("Liters to Gallons = "+ConvertLitersToGallons(l));
	}
}
