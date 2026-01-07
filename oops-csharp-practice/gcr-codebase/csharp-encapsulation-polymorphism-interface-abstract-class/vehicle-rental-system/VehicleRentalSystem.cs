using System;

class VehicleRentalSystem
{
    static void Main()
    {
        Vehicle[] vehicleList = new Vehicle[3];

        Console.WriteLine("Enter Car Details");
        Console.Write("Vehicle Number: ");
        string carNumber = Console.ReadLine();
        Console.Write("Rental Rate Per Day: ");
        double carRentalRate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insurance Policy Number: ");
        string carInsurancePolicy = Console.ReadLine();

        Car carVehicle = new Car(carRentalRate, carInsurancePolicy);
        carVehicle.VehicleNumber = carNumber;
        carVehicle.VehicleType = "Car";

        vehicleList[0] = carVehicle;

        Console.WriteLine("\nEnter Bike Details");
        Console.Write("Vehicle Number: ");
        string bikeNumber = Console.ReadLine();
        Console.Write("Rental Rate Per Day: ");
        double bikeRentalRate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insurance Policy Number: ");
        string bikeInsurancePolicy = Console.ReadLine();

        Bike bikeVehicle = new Bike(bikeRentalRate, bikeInsurancePolicy);
        bikeVehicle.VehicleNumber = bikeNumber;
        bikeVehicle.VehicleType = "Bike";

        vehicleList[1] = bikeVehicle;

        Console.WriteLine("\nEnter Truck Details");
        Console.Write("Vehicle Number: ");
        string truckNumber = Console.ReadLine();
        Console.Write("Rental Rate Per Day: ");
        double truckRentalRate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insurance Policy Number: ");
        string truckInsurancePolicy = Console.ReadLine();

        Truck truckVehicle = new Truck(truckRentalRate, truckInsurancePolicy);
        truckVehicle.VehicleNumber = truckNumber;
        truckVehicle.VehicleType = "Truck";

        vehicleList[2] = truckVehicle;

        Console.Write("\nEnter Number of Rental Days: ");
        int totalRentalDays = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nRental and Insurance Details");

        for (int index = 0; index < vehicleList.Length; index++)
        {
            double rentalCost = vehicleList[index].CalculateRentalCost(totalRentalDays);

            double insuranceCost = 0;

            //check if vehicle is insurable
            if (vehicleList[index] is IInsurable)
            {
                IInsurable insurableVehicle = (IInsurable)vehicleList[index];
                insuranceCost = insurableVehicle.CalculateInsurance();
            }

            Console.WriteLine("Vehicle Number: " + vehicleList[index].VehicleNumber);
            Console.WriteLine("Vehicle Type: " + vehicleList[index].VehicleType);
            Console.WriteLine("Rental Cost: " + rentalCost);
            Console.WriteLine("Insurance Cost: " + insuranceCost);
            Console.WriteLine();
        }
    }
}
