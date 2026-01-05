using System;

class Car : Vehicle, IRentable
{
    public Car(string model, double rate)
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
        Console.WriteLine("Vehicle Type: Car");
    }
}
