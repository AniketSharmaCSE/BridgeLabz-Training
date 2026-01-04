using System;

public class Circle
{
    double radius;
    //Constructor to initialize radius
    public Circle(double radius){
        this.radius = radius;
    }

    //calculate area of circle
    public double CalculateArea()
    {
        return 3.14 * radius * radius;
    }


    //calculate circumference of circle
    public double CalculateCircumference()
    {
      
        return 2 * 3.14 * radius;
    }


    //display results
    public void DisplayDetails()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area of Circle: " + CalculateArea());
        Console.WriteLine("Circumference of Circle: " + CalculateCircumference());
    }
}
