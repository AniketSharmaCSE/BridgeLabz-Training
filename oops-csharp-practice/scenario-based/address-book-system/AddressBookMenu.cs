using System;

public class AddressBookMenu
{
    private Contacts contact;
    private IContactUtility contactUtility;

    public AddressBookMenu()
    {
        contactUtility = new ContactUtilityImpl();
    }

    public void Start()
    {
        int choice = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Contact");   //UC2
            Console.WriteLine("2. Edit Contact");  //UC3
            Console.WriteLine("3. Delete Contact");//UC4
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    contact = contactUtility.AddContact();
                    break;

                case 2:
                    contactUtility.EditContact(contact);
                    break;

                case 3:
                    contact = contactUtility.DeleteContact(contact);
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
