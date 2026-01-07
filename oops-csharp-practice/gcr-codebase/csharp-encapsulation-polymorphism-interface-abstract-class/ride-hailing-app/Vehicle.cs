using System;

public abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    protected double ratePerKm;

    public int VehicleId
    {
        get 
        { 
            return vehicleId; 
        }
        set 
        { 
            vehicleId = value; 
        }
    
    }

    public string DriverName
    {
        get 
        { 
            return driverName; 
        }
        set 
        { 
            driverName = value; 
        }
    
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle Id: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
    }
}
