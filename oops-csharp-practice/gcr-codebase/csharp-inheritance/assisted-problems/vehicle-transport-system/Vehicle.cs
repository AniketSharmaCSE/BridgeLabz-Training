using System;

class Vehicle
{
    public int MaxSpeed;
    public string FuelType;

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    //Method to display vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}
