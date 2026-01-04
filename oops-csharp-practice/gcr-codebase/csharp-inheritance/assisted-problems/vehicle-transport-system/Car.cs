using System;

class Car : Vehicle
{
    public int SeatCapacity;

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    //Override to display car specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: " + SeatCapacity);
    }
}
