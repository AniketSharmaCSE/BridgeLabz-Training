using System;

public class Circle
{
    double radius;
    //Default constructor
    public Circle()
    {
        //Calling parameterized constructor
        this.radius = 1;
    }

    //Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }


    //Method to calculate area
    public void CalculateArea()
    {
        Console.WriteLine(3.14 * radius * radius);
    }
}
