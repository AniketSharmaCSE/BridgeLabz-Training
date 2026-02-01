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

            try
            {
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

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        throw new InvalidChoiceException("Invalid menu choice");
                }
            }
            catch (InvalidChoiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        } while (choice != 0);
    }

    //UC6:Add new Address Book
    private void AddAddressBook()
    {
        Console.WriteLine("Enter Address Book Name:");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new EmptyInputException("Address Book name cannot be empty");
        }

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
            throw new AddressBookNotFoundException("Address Book not found");
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
            Console.WriteLine("7. Save Contacts to File"); //UC13
            Console.WriteLine("8. Load Contacts from File"); //UC13
            Console.WriteLine("0. Back");

            Console.WriteLine("Enter your choice:");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Contacts c = contactUtility.AddContact(book.contacts);
                            if (c != null)
                            {
                                book.contacts.Add(c);
                            }
                        }
                        catch (DuplicateContactException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (EmptyInputException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (InvalidPhoneNumberException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            contactUtility.EditContact(book.contacts);
                        }
                        catch (ContactNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            contactUtility.DeleteContact(book.contacts);
                        }
                        catch (ContactNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
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

                    case 7:
                        Console.WriteLine("Enter file path:");
                        string savePath = Console.ReadLine();
                        contactUtility.SaveToFile(book.contacts, savePath);
                        break;

                    case 8:
                        Console.WriteLine("Enter file path:");
                        string loadPath = Console.ReadLine();
                        contactUtility.LoadFromFile(book.contacts, loadPath);
                        break;


                    case 0:
                        Console.WriteLine("Going back...");
                        break;

                    default:
                        throw new InvalidChoiceException("Invalid menu choice");
                }
            }
            catch (InvalidChoiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        } while (choice != 0);
    }
}
