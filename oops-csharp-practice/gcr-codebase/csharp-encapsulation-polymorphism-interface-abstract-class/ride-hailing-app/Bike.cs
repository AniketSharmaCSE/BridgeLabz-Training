using System;

public class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public Bike(double ratePerKm)
    {
        this.ratePerKm = ratePerKm;
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}
