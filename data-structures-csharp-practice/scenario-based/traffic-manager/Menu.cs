class TrafficManager
{
    private Roundabout roundabout = new Roundabout();
    private VehicleQueue queue = new VehicleQueue(5);

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Vehicle to Queue");
            Console.WriteLine("2. Allow Vehicle into Roundabout");
            Console.WriteLine("3. Remove Vehicle from Roundabout");
            Console.WriteLine("4. Print Roundabout State");
            Console.WriteLine("5. Exit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter vehicle number: ");
                    queue.Enqueue(Console.ReadLine());
                    break;

                case "2":
                    string vehicle = queue.Dequeue();
                    if (vehicle != null)
                        roundabout.AddVehicle(vehicle);
                    break;

                case "3":
                    roundabout.RemoveVehicle();
                    break;

                case "4":
                    roundabout.PrintState();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
