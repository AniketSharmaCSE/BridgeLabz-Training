using System;

public class CircleDetails
{
    static void Main(string[] args)
    {
        //Taking radius input from user
        Console.WriteLine("Enter radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());
        //Creating object using constructor
        Circle circle = new Circle(radius);

        Console.WriteLine();
        circle.DisplayDetails();
    }
}
