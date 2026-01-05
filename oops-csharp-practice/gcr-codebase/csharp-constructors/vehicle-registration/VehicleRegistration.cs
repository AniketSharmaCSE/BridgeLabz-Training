using System;

public class VehicleRegistration
{
    static void Main(string[] args)
    {
        //Updating registration fee using class method
        Console.WriteLine("Enter registration fee:");
        double fee = Convert.ToDouble(Console.ReadLine());
        Vehicle.UpdateRegistrationFee(fee);


        Console.WriteLine("Enter number of vehicles:");
        int count = Convert.ToInt32(Console.ReadLine());
		
		
        for (int i = 0; i < count; i++)
        {
            //Taking user input for vehicle details
            Console.WriteLine("Enter owner name:");
            string owner = Console.ReadLine();
            Console.WriteLine("Enter vehicle type:");
            string type = Console.ReadLine();

            Vehicle vehicle = new Vehicle(owner, type);
            vehicle.DisplayVehicleDetails();
			
        
		}
    
	}
}
