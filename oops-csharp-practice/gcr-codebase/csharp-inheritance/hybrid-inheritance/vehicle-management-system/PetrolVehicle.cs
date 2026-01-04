using System;

class PetrolVehicle : Vehicle, Refuelable
{
    public PetrolVehicle(int maxSpeed, string model)
        : base(maxSpeed, model)
    {
    }

    //Implementation of refuelable behavior
    public void Refuel()
    {
        Console.WriteLine(Model + " is being refueled");
    }
}
