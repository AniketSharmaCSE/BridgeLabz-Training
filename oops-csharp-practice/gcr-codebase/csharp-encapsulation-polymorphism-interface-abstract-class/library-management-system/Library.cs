using System;

class Library
{
    static void Main()
    {
        LibraryItem[] libraryItemList = new LibraryItem[3];

        Console.WriteLine("Enter Book Details");
        Book bookItem = new Book();
        Console.Write("Item Id: ");
        bookItem.ItemId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Title: ");
        bookItem.Title = Console.ReadLine();
        Console.Write("Author: ");
        bookItem.Author = Console.ReadLine();

        libraryItemList[0] = bookItem;

        Console.WriteLine("\nEnter Magazine Details");
        Magazine magazineItem = new Magazine();
        Console.Write("Item Id: ");
        magazineItem.ItemId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Title: ");
        magazineItem.Title = Console.ReadLine();
        Console.Write("Author: ");
        magazineItem.Author = Console.ReadLine();

        libraryItemList[1] = magazineItem;

        Console.WriteLine("\nEnter DVD Details");
        DVD dvdItem = new DVD();
        
        Console.Write("Item Id: ");
        dvdItem.ItemId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Title: ");
        dvdItem.Title = Console.ReadLine();
        Console.Write("Author: ");
        dvdItem.Author = Console.ReadLine();

        libraryItemList[2] = dvdItem;

        Console.WriteLine("\nLibrary Item Details");

        for (int index = 0; index < libraryItemList.Length; index++)
        {
            libraryItemList[index].GetItemDetails();

            //check reservation only if item is reservable
            if (libraryItemList[index] is IReservable)
            {
                IReservable reservableItem = (IReservable)libraryItemList[index];

                Console.WriteLine("Available: " + reservableItem.CheckAvailability());

                Console.Write("Do you want to reserve this item? (yes/no): ");
                string userChoice = Console.ReadLine();

                if (userChoice == "yes")
                {
                    reservableItem.ReserveItem();
                    Console.WriteLine("Item Reserved");
                }
            }

            Console.WriteLine();
        }
    }
}
