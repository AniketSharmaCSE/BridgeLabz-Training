using System;

public class MileAndYard
{
    public static void Main(string[] args)
    {
        //ask user for distance in feet
        Console.WriteLine("Enter distance in feet");
        double Feet=Convert.ToDouble(Console.ReadLine());

        //convert feet to yard
        double Yard=Feet/3;
        //convert yard to miles
        double Miles=Yard/1760;

        Console.WriteLine("Your distance in feet is "+Feet+" while in yard is "+Yard+" and miles is "+Miles);
    }
}
