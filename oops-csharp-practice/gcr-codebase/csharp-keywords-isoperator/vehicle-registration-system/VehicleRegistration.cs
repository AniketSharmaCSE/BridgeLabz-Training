using System;

public class VehicleRegistration
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter registration fee:");
        double fee = Convert.ToDouble(Console.ReadLine());
        Vehicle.UpdateRegistrationFee(fee);


        Console.WriteLine("Enter number of vehicles:");
        int count = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter owner name:");
            string owner = Console.ReadLine();
            Console.WriteLine("Enter vehicle type:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter registration number:");
            string regNo = Console.ReadLine();


            Vehicle vehicle = new Vehicle(owner, type, regNo);

            //Verifying object type before accessing details
            if (vehicle is Vehicle)
            {
                vehicle.ShowVehicleDetails();

            }

        }

    }
}
