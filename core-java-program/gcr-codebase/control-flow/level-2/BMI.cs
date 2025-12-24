using System;

public class BMI
{
    static void Main(string[] args)
    {
        //Ask user for their weight and height
        Console.WriteLine("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());


        //Convert height to meters
        double height = heightCm / 100;

        //Calculate and print BMI
        double bmi = weight / (height * height);
        Console.WriteLine("BMI value is: " + bmi);
    }
}
