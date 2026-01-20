using System;

class Warehouse
{
    static void Main(string[] args)
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        Storage<Groceries> groceryStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("\n--- Warehouse Menu ---");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Display All Items");
            Console.WriteLine("3. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Select Item Type:");
                    Console.WriteLine("1. Electronics");
                    Console.WriteLine("2. Groceries");
                    Console.WriteLine("3. Furniture");

                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter item name:");
                    string name = Console.ReadLine();

                    if (type == 1)
                    {
                        electronicsStorage.AddItem(new Electronics(name));
                    }
                    else if (type == 2)
                    {
                        groceryStorage.AddItem(new Groceries(name));
                    }
                    else if (type == 3)
                    {
                        furnitureStorage.AddItem(new Furniture(name));
                    }
                    else
                    {
                        Console.WriteLine("Invalid item type");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Electronics Items ---");
                    electronicsStorage.DisplayItems();

                    Console.WriteLine("\n--- Grocery Items ---");
                    groceryStorage.DisplayItems();

                    Console.WriteLine("\n--- Furniture Items ---");
                    furnitureStorage.DisplayItems();
                    break;

                case 3:
                    Console.WriteLine("Exiting Warehouse System");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
