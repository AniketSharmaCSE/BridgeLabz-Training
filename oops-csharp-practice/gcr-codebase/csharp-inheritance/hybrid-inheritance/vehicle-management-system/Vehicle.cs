using System;

class Vehicle
{
    public int MaxSpeed;
    public string Model;

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    //Method to display basic vehicle info
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Max Speed: " + MaxSpeed);
    }
}
