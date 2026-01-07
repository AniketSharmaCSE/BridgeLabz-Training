using System;

public abstract class Vehicle
{
    private string vehicleNumber;
    private string vehicleType;
    protected double rentalRatePerDay;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string VehicleType
    {
        get { return vehicleType; }
        set { vehicleType = value; }
    }

    public abstract double CalculateRentalCost(int totalDays);
}
