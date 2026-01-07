using System;

class RideHailingApp
{
    static void Main()
    {
        Vehicle[] vehicleList = new Vehicle[3];

        Console.WriteLine("Enter Car Details");
        Console.Write("Vehicle Id: ");
        int carVehicleId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Driver Name: ");
        string carDriverName = Console.ReadLine();
        Console.Write("Rate Per Km: ");
        double carRatePerKm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Current Location: ");
        string carLocation = Console.ReadLine();

        Car carVehicle = new Car(carRatePerKm);
        carVehicle.VehicleId = carVehicleId;
        carVehicle.DriverName = carDriverName;
        carVehicle.UpdateLocation(carLocation);

        vehicleList[0] = carVehicle;

        Console.WriteLine("\nEnter Bike Details");
        Console.Write("Vehicle Id: ");
        int bikeVehicleId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Driver Name: ");
        string bikeDriverName = Console.ReadLine();
        Console.Write("Rate Per Km: ");
        double bikeRatePerKm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Current Location: ");
        string bikeLocation = Console.ReadLine();

        Bike bikeVehicle = new Bike(bikeRatePerKm);
        bikeVehicle.VehicleId = bikeVehicleId;
        bikeVehicle.DriverName = bikeDriverName;
        bikeVehicle.UpdateLocation(bikeLocation);

        vehicleList[1] = bikeVehicle;

        Console.WriteLine("\nEnter Auto Details");
        Console.Write("Vehicle Id: ");
        int autoVehicleId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Driver Name: ");
        string autoDriverName = Console.ReadLine();
        Console.Write("Rate Per Km: ");
        double autoRatePerKm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Current Location: ");
        string autoLocation = Console.ReadLine();

        Auto autoVehicle = new Auto(autoRatePerKm);
        autoVehicle.VehicleId = autoVehicleId;
        autoVehicle.DriverName = autoDriverName;
        autoVehicle.UpdateLocation(autoLocation);

        vehicleList[2] = autoVehicle;

        Console.Write("\nEnter Travel Distance (Km): ");
        double travelDistance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nRide Fare Details");

        for (int index = 0; index < vehicleList.Length; index++)
        {
            vehicleList[index].GetVehicleDetails();

            double fareAmount =
                vehicleList[index].CalculateFare(travelDistance);

            Console.WriteLine("Fare: " + fareAmount);

            //gps details only if supported
            if (vehicleList[index] is IGPS)
            {
                IGPS gpsEnabledVehicle =
                    (IGPS)vehicleList[index];

                Console.WriteLine(
                    "Current Location: " +
                    gpsEnabledVehicle.GetCurrentLocation()
                );
            }

            Console.WriteLine();
        }
    }
}
