using System;

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    //Override to display motorcycle specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + HasSidecar);
    }
}
