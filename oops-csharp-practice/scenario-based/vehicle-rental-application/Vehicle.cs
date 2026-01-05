using System;

class Vehicle
{
    protected string Model;
    protected double RatePerDay;

    public Vehicle(string model, double rate)
    {
        Model = model;
        RatePerDay = rate;
    }

    //Method to display vehicle info
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Rate Per Day: " + RatePerDay);
    }
}
