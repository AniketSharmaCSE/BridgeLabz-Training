using System;

public class AddressBookMenu
{
    //UC6:Multiple Address Books
    private AddressBook[] addressBooks;
    private int addressBookCount;

    private IContactUtility contactUtility;

    public AddressBookMenu()
    {
        contactUtility = new ContactUtilityImpl();
        addressBooks = new AddressBook[10];
        addressBookCount = 0;
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
			Console.WriteLine("4. View Persons by City or State"); //UC9
			Console.WriteLine("5. Count Persons by City or State"); //UC10
			Console.WriteLine("0. Exit");

            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddAddressBook();
                    break;

                case 2:
                    SelectAddressBook();
                    break;
					
				case 3:
					contactUtility.SearchByCityOrState(addressBooks, addressBookCount);
					break;
					
				case 4:
					contactUtility.ViewPersonsByCityOrState(addressBooks, addressBookCount);
					break;
				
				case 5:
					contactUtility.CountByCityOrState(addressBooks, addressBookCount);
					break;

                case 0:
                    Console.WriteLine("Exiting Address Book");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 0);
    }

    //UC6:Add new Address Book
    private void AddAddressBook()
    {
        if (addressBookCount >= addressBooks.Length)
        {
            Console.WriteLine("Address Book limit reached");
            return;
        }

        Console.WriteLine("Enter Address Book Name:");
        string name = Console.ReadLine();

        if (IsDuplicateAddressBook(name))
        {
            Console.WriteLine("Address Book already exists");
            return;
        }

        addressBooks[addressBookCount] = new AddressBook(name);
        addressBookCount++;

        Console.WriteLine("Address Book created successfully");
    }

    //UC6:Check duplicate Address Book name
    private bool IsDuplicateAddressBook(string name)
    {
        for (int i = 0; i < addressBookCount; i++)
        {
            if (addressBooks[i].bookName.Equals(name))
            {
                return true;
            }
        }
        return false;
    }

    //UC6:Select Address Book
    private void SelectAddressBook()
    {
        if (addressBookCount == 0)
        {
            Console.WriteLine("No Address Books available");
            return;
        }

        Console.WriteLine("Available Address Books:");
        for (int i = 0; i < addressBookCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + addressBooks[i].bookName);
        }

        Console.WriteLine("Select Address Book number:");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= addressBookCount)
        {
            Console.WriteLine("Invalid selection");
            return;
        }

        OpenAddressBook(addressBooks[choice]);
    }

    //UC6:Operate on selected Address Book
    private void OpenAddressBook(AddressBook book)
    {
        int choice = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Address Book: " + book.bookName);
            Console.WriteLine("1. Add Contact");      //UC2 + UC5
            Console.WriteLine("2. Edit Contact");     //UC3
            Console.WriteLine("3. Delete Contact");   //UC4
            Console.WriteLine("4. Show All Contacts");//UC5
			Console.WriteLine("5. Sort Contacts by Name"); //UC11
            Console.WriteLine("0. Back");
            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
					if (book.contactCount < book.contacts.Length)
					{
						Contacts contact = contactUtility.AddContact(book.contacts, book.contactCount);
						if (contact != null)
						{
							book.contacts[book.contactCount] = contact;
							book.contactCount++;
						}
					}
					else
					{
						Console.WriteLine("Address Book is full");
					}
						break;

                case 2:
                    contactUtility.EditContact(book.contacts, book.contactCount);
                    break;

                case 3:
                    book.contactCount = contactUtility.DeleteContact(book.contacts, book.contactCount);
                    break;

                case 4:
                    contactUtility.ShowAllContacts(book.contacts, book.contactCount);
                    break;
				
				case 5:
					contactUtility.SortContactsByName(book.contacts, book.contactCount);
					break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 0);
    }
}
