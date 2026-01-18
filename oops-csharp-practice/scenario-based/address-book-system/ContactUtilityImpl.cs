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
	
	 //UC8:Search contacts by city or state across address books
    public void SearchByCityOrState(AddressBook[] addressBooks, int bookCount)
    {
        Console.WriteLine("Search by:");
        Console.WriteLine("1. City");
        Console.WriteLine("2. State");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter search value:");
        string value = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBook book = addressBooks[i];

            for (int j = 0; j < book.contactCount; j++)
            {
                Contacts c = book.contacts[j];

                if ((choice == 1 && c.GetAddressDetails().Contains(value)) ||
                    (choice == 2 && c.GetAddressDetails().Contains(value)))
                {
                    Console.WriteLine("Address Book: " + book.bookName);
                    Console.WriteLine("Name: " + c.GetFullName());
                    Console.WriteLine("Address: " + c.GetAddressDetails());
                    Console.WriteLine("Phone: " + c.GetPhoneNumber());
                    Console.WriteLine("Email: " + c.GetEmail());
                    Console.WriteLine();
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching contacts found");
        }
    }
}

