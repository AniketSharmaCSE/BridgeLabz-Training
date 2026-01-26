using System;
using System.Collections.Generic;

public class AddressBookMenu
{
    //UC6:Multiple Address Books
    private Dictionary<string, AddressBook> addressBooks;

    private IContactUtility contactUtility;

    public AddressBookMenu()
    {
        contactUtility = new ContactUtilityImpl();
        addressBooks = new Dictionary<string, AddressBook>();
    }

    public void Start()
    {
        int choice = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Search Person by City or State"); //UC8
            Console.WriteLine("4. View Persons by City or State");  //UC9
            Console.WriteLine("5. Count Persons by City or State"); //UC10
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddAddressBook(); //UC6
                    break;

                case 2:
                    SelectAddressBook(); //UC6
                    break;

                case 3:
                    contactUtility.SearchByCityOrState(addressBooks); //UC8
                    break;

                case 4:
                    contactUtility.ViewPersonsByCityOrState(addressBooks); //UC9
                    break;

                case 5:
                    contactUtility.CountByCityOrState(addressBooks); //UC10
                    break;
            }

        } while (choice != 0);
    }

    //UC6:Add new Address Book
    private void AddAddressBook()
    {
        Console.WriteLine("Enter Address Book Name:");
        string name = Console.ReadLine();

        if (addressBooks.ContainsKey(name))
        {
            Console.WriteLine("Address Book already exists");
            return;
        }

        addressBooks.Add(name, new AddressBook(name));
        Console.WriteLine("Address Book created successfully");
    }

    //UC6:Select Address Book
    private void SelectAddressBook()
    {
        Console.WriteLine("Enter Address Book Name:");
        string name = Console.ReadLine();

        if (!addressBooks.ContainsKey(name))
        {
            Console.WriteLine("Address Book not found");
            return;
        }

        OpenAddressBook(addressBooks[name]);
    }

    //UC6:Operate on selected Address Book
    private void OpenAddressBook(AddressBook book)
    {
        int choice = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Address Book: " + book.BookName);
            Console.WriteLine("1. Add Contact");       //UC2 + UC7
            Console.WriteLine("2. Edit Contact");      //UC3
            Console.WriteLine("3. Delete Contact");    //UC4
            Console.WriteLine("4. Show All Contacts"); //UC5
            Console.WriteLine("5. Sort Contacts by Name"); //UC11
            Console.WriteLine("6. Sort Contacts by City/State/Zip"); //UC12
            Console.WriteLine("0. Back");

            Console.WriteLine("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Contacts c = contactUtility.AddContact(book.contacts);
                    if (c != null)
                    {
                        book.contacts.Add(c);
                    }
                    break;

                case 2:
                    contactUtility.EditContact(book.contacts);
                    break;

                case 3:
                    contactUtility.DeleteContact(book.contacts);
                    break;

                case 4:
                    contactUtility.ShowAllContacts(book.contacts);
                    break;

                case 5:
                    contactUtility.SortContactsByName(book.contacts);
                    break;

                case 6:
                    contactUtility.SortContactsByCityStateOrZip(book.contacts);
                    break;
            }

        } while (choice != 0);
    }
}
