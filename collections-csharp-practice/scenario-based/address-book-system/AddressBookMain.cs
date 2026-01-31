using System;

public class AddressBookMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");

        AddressBookMenu menu = new AddressBookMenu();
        menu.Start();
    }
}
