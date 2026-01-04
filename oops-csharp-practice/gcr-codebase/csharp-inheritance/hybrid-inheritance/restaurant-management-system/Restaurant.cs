using System;

class Restaurant
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select role:");
        Console.WriteLine("1.Chef");
        Console.WriteLine("2.Waiter");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter id:");
        int id = Convert.ToInt32(Console.ReadLine());

        Worker worker;

        if (choice == 1)
        {
            Console.WriteLine("Enter special dish:");
            string dish = Console.ReadLine();

            worker = new Chef(name, id, dish);
        }
        else
        {
            Console.WriteLine("Enter number of tables assigned:");
            int tables = Convert.ToInt32(Console.ReadLine());

            worker = new Waiter(name, id, tables);
        }

        worker.PerformDuties();
    }
}
