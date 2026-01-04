using System;

class ElectricVehicle : Vehicle
{
    public ElectricVehicle(int maxSpeed, string model)
        : base(maxSpeed, model)
    {
    }

    //Method specific to electric vehicles
    public void Charge()
    {
        Console.WriteLine(Model + " is charging");
    }
}
