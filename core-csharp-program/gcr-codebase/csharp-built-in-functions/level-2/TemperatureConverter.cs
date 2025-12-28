using System;

public class TemperatureConverter
{
    //Method to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }



    //Method to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
	
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature: ");
        double value = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Convert to (C/F): ");
        char choice = Console.ReadLine()[0];

        
        if (choice == 'C')
        {
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(value));
        }
        else
        {
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(value));
        }
    }
}
