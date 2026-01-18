using System;

public class ContactUtilityImpl : IContactUtility
{
    //UC2:method to add contacts
    public Contacts AddContact()
    {
        return AddContact(null, 0);
    }

    //UC7:Add contact with duplicate check
    public Contacts AddContact(Contacts[] contacts, int count)
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        //UC7:Duplicate check
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].IsSamePerson(firstName, lastName))
            {
                Console.WriteLine("Duplicate contact found. Contact not added");
                return null;
            }
        }

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
    public void EditContact(Contacts[] contacts, int count)
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts available");
            return;
        }

        Console.WriteLine("Enter First Name to edit:");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name))
            {
                Console.WriteLine("Enter new City:");
                contacts[i].SetCity(Console.ReadLine());
                Console.WriteLine("Contact updated successfully");
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }

    //UC4:Method to delete existing contact
    public int DeleteContact(Contacts[] contacts, int count)
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts to delete");
            return count;
        }

        Console.WriteLine("Enter First Name to delete:");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name))
            {
                for (int j = i; j < count - 1; j++)
                {
                    contacts[j] = contacts[j + 1];
                }

                contacts[count - 1] = null;
                Console.WriteLine("Contact deleted successfully");
                return count - 1;
            }
        }

        Console.WriteLine("Contact not found");
        return count;
    }

    //UC5:Show all contacts
    public void ShowAllContacts(Contacts[] contacts, int count)
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts available");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Name: " + contacts[i].GetFullName());
            Console.WriteLine("Address: " + contacts[i].GetAddressDetails());
            Console.WriteLine("Phone: " + contacts[i].GetPhoneNumber());
            Console.WriteLine("Email: " + contacts[i].GetEmail());
            Console.WriteLine();
        }
    }
}
