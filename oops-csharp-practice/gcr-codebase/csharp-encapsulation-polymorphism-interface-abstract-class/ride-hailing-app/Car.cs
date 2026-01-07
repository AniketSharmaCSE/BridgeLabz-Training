using System;

public class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(double ratePerKm)
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
