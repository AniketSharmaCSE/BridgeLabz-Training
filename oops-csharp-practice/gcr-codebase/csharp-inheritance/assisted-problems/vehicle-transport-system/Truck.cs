using System;

class Truck : Vehicle
{
    public int PayloadCapacity;

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    //Override to display truck specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + PayloadCapacity);
    }
}
