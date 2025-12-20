using System;

public class VolumeOfEarth
{
    public static void Main(string[] args)
    {
        //define radius of earth
        int radius=6378;

        //define value of pi
        double pi=3.14;

        //calculate volume of earth
        double volume=(4.0/3)*pi*radius*radius*radius;

        //convert volume into miles
        double inMiles=volume*1.6;

        //print the result
        Console.WriteLine("The volume of earth in cubic kilometers is "+volume+" and cubic miles is "+inMiles);
    }
}
