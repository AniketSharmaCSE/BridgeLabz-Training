using System;

public class PersonMain
{
    static void Main(string[] args)
    {
        //Object using default constructor
        Circle c1 = new Circle();
        //Object using parameterized constructor
        Circle c2 = new Circle(5);

        c1.CalculateArea();
        c2.CalculateArea();
    }
}
