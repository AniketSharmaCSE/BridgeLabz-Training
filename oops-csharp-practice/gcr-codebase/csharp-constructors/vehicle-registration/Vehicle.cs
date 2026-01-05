using System;

public class Vehicle
{
    string ownerName;
    string vehicleType;

    //Class variable fixed for all vehicles
    static double registrationFee = 1500;
    //Constructor to initialize vehicle details
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }


    //Instance method to display vehicle details
    public void DisplayVehicleDetails(){
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }


    //Class method to update registration fee
    public static void UpdateRegistrationFee(double fee)
    {
        registrationFee = fee;
		
    }
	
}
