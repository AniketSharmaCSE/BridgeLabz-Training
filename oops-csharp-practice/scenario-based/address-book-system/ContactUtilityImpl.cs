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

    
}
