using System;

public class Vehicle
{
    //Common registration fee for all vehicles
    public static double RegistrationFee = 2000;

    string ownerName;
    string vehicleType;
    readonly string registrationNumber;


    //Constructor assigns vehicle information
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.registrationNumber = registrationNumber;

    }


    //Prints registration details
    public void ShowVehicleDetails()
    {	
		Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Number: " + registrationNumber);
        Console.WriteLine("Registration Fee: " + RegistrationFee);
		
    }


    //Updates registration fee for all vehicles
    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }

}
