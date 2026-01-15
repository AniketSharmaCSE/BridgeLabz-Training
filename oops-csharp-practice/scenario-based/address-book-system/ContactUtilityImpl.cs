using System;

public class ContactUtilityImpl : IContactUtility
{
    //UC2:method to add contacts
    public Contacts AddContact()
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Address:");
        string address = Console.ReadLine();
        Console.WriteLine("Enter City:");
        string city = Console.ReadLine();
        Console.WriteLine("Enter State:");
        string state = Console.ReadLine();
        Console.WriteLine("Enter Zip:");
        string zip = Console.ReadLine();
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();

        Contacts contact = new Contacts(
            firstName,
            lastName,
            address,
            city,
            state,
            zip,
            phoneNumber,
            email
        );

        Console.WriteLine("Contact added successfully");

        return contact;
    }

    //UC3:Method to edit existing contact
    public void EditContact(Contacts contact)
    {
        if (contact == null)
        {
            Console.WriteLine("No contact available to edit");
            return;
        }

        Console.WriteLine("Enter First Name to edit contact:");
        string name = Console.ReadLine();

        if (!contact.GetFirstName().Equals(name))
        {
            Console.WriteLine("Contact not found");
            return;
        }

        Console.WriteLine("What do you want to edit?");
        Console.WriteLine("1. Address");
        Console.WriteLine("2. City");
        Console.WriteLine("3. State");
        Console.WriteLine("4. Phone Number");
        Console.WriteLine("5. Email");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter new Address:");
                contact.SetAddress(Console.ReadLine());
                break;

            case 2:
                Console.WriteLine("Enter new City:");
                contact.SetCity(Console.ReadLine());
                break;

            case 3:
                Console.WriteLine("Enter new State:");
                contact.SetState(Console.ReadLine());
                break;

            case 4:
                Console.WriteLine("Enter new Phone Number:");
                contact.SetPhoneNumber(Console.ReadLine());
                break;

            case 5:
                Console.WriteLine("Enter new Email:");
                contact.SetEmail(Console.ReadLine());
                break;

            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        Console.WriteLine("Contact updated successfully");
    }

}
