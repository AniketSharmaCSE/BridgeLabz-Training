using System;

public class AddressBookMenu
{
    private Contacts[] contacts;
    private int contactCount;
    private IContactUtility contactUtility;

    public AddressBookMenu()
    {
        contactUtility = new ContactUtilityImpl();
        contacts = new Contacts[100]; 
        contactCount = 0;
    }

    public void Start()
    {
        int choice = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Contact");     //UC2 + UC5
            Console.WriteLine("2. Edit Contact");    //UC3
            Console.WriteLine("3. Delete Contact");  //UC4
            Console.WriteLine("4. Show All Contacts");//UC5
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (contactCount < contacts.Length)
                    {
                        contacts[contactCount] = contactUtility.AddContact();
                        contactCount++;
                    }
                    else
                    {
                        Console.WriteLine("Address Book is full");
                    }
                    break;

                case 2:
                    contactUtility.EditContact(contacts, contactCount);
                    break;

                case 3:
                    contactCount = contactUtility.DeleteContact(contacts, contactCount);
                    break;

                case 4:
                    contactUtility.ShowAllContacts(contacts, contactCount);
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
}
