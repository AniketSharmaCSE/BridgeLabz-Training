using System;

public class TakingInput
{
    public static void Main(string[] args)
    {
        //take input in kilometers
        double Km=Convert.ToDouble(Console.ReadLine());

        //convert kilometers to miles
        double Miles=Km*1.6;

        //print the result
        Console.WriteLine("The total miles is "+Miles+" mile for the given "+Km+" km");
    }
}
