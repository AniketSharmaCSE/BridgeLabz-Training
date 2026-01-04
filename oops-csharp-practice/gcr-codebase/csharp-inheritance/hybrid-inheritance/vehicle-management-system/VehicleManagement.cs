using System;

class VehicleManagement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select vehicle type:");
        Console.WriteLine("1.Electric Vehicle");
        Console.WriteLine("2.Petrol Vehicle");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter model:");
        string model = Console.ReadLine();
        Console.WriteLine("Enter max speed:");
        int maxSpeed = Convert.ToInt32(Console.ReadLine());

        Vehicle vehicle;

        if (choice == 1)
        {
            ElectricVehicle ev = new ElectricVehicle(maxSpeed, model);
            vehicle = ev;

            vehicle.DisplayInfo();
            ev.Charge();
        }
        else
        {
            PetrolVehicle pv = new PetrolVehicle(maxSpeed, model);
            vehicle = pv;

            vehicle.DisplayInfo();
            pv.Refuel();
        }
    }
}
