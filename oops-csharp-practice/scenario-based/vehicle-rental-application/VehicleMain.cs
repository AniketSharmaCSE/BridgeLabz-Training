using System;

class VehicleMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter customer name:");
        Customer customer = new Customer(Console.ReadLine());

        Console.WriteLine("Select vehicle:");
        Console.WriteLine("1.Bike");
        Console.WriteLine("2.Car");
        Console.WriteLine("3.Truck");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter model:");
        string model = Console.ReadLine();

        Console.WriteLine("Enter rate per day:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter rental days:");
        int days = Convert.ToInt32(Console.ReadLine());

        Vehicle vehicle;
        IRentable rentable;

        if (choice == 1)
        {
            Bike bike = new Bike(model, rate);
            vehicle = bike;
            rentable = bike;
        }
        else if (choice == 2)
        {
            Car car = new Car(model, rate);
            vehicle = car;
            rentable = car;
        }
        else
        {
            Truck truck = new Truck(model, rate);
            vehicle = truck;
            rentable = truck;
        }

        vehicle.DisplayInfo();
        Console.WriteLine("Total Rent: " + rentable.CalculateRent(days));
    }
}
