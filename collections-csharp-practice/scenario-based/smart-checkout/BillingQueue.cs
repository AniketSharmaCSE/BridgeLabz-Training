using System;

class BillingQueue
{
    static void Main()
    {
        Inventory inventory = new Inventory();
        CheckoutCounter counter = new CheckoutCounter(inventory);

        while (true) // ROLE selection loop
        {
            Console.WriteLine("\nSelect Role");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Cashier");
            Console.WriteLine("3. Exit Application");
            Console.Write("Choice: ");

            int role = int.Parse(Console.ReadLine());

            if (role == 1)
            {
                // MANAGER MENU LOOP
                while (true)
                {
                    Console.WriteLine("\nManager Menu");
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Remove Item");
                    Console.WriteLine("3. View Inventory");
                    Console.WriteLine("4. Exit Manager Menu");
                    Console.Write("Choice: ");

                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        inventory.AddItem();
                    }
                    else if (choice == 2)
                    {
                        inventory.RemoveItem();
                    }
                    else if (choice == 3)
                    {
                        inventory.ViewInventory();
                    }
                    else if (choice == 4)
                    {
                        break; // exit manager menu only
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }
            }

            else if (role == 2)
            {
                // CASHIER MENU LOOP
                while (true)
                {
                    Console.WriteLine("\nCashier Menu");
                    Console.WriteLine("1. Add Customer");
                    Console.WriteLine("2. Process Customer");
                    Console.WriteLine("3. Exit Cashier Menu");
                    Console.Write("Choice: ");

                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        counter.AddCustomer();
                    }
                    else if (choice == 2)
                    {
                        counter.ProcessCustomer();
                    }
                    else if (choice == 3)
                    {
                        break; // exit cashier menu only
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }
            }

            else if (role == 3)
            {
                Console.WriteLine("Application Closed");
                break; // exit whole program
            }

            else
            {
                Console.WriteLine("Invalid role selection");
            }
        }
    }
}
