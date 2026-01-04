using System;

class TransportSystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of vehicles:");
        int count = Convert.ToInt32(Console.ReadLine());

        Vehicle[] vehicles = new Vehicle[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Select vehicle type:");
            Console.WriteLine("1.Car");
            Console.WriteLine("2.Truck");
            Console.WriteLine("3.Motorcycle");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter max speed:");
            int maxSpeed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fuel type:");
            string fuelType = Console.ReadLine();

            if (choice == 1)
            {
                Console.WriteLine("Enter seat capacity:");
                int seatCapacity = Convert.ToInt32(Console.ReadLine());

                vehicles[i] = new Car(maxSpeed, fuelType, seatCapacity);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter payload capacity:");
                int payloadCapacity = Convert.ToInt32(Console.ReadLine());

                vehicles[i] = new Truck(maxSpeed, fuelType, payloadCapacity);
            }
            else
            {
                Console.WriteLine("Has sidecar? true/false:");
                bool hasSidecar = Convert.ToBoolean(Console.ReadLine());

                vehicles[i] = new Motorcycle(maxSpeed, fuelType, hasSidecar);
            }
        }

        Console.WriteLine("Vehicle Details:");

        //Polymorphism:dynamic method dispatch
        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].DisplayInfo();
            Console.WriteLine();
        }
    }
}
