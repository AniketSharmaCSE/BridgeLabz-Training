using System;

class Truck : Vehicle, IRentable
{
    public Truck(string model, double rate)
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
        Console.WriteLine("Vehicle Type: Truck");
    }
}
