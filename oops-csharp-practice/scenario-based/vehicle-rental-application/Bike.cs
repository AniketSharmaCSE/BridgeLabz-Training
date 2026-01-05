using System;

class Bike : Vehicle, IRentable
{
    public Bike(string model, double rate)
        : base(model, rate)
    {
    }

    public double CalculateRent(int days)
    {
        return RatePerDay * days;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Vehicle Type: Bike");
    }
}
