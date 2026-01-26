using System;
using System.Collections.Generic;

public class ContactUtilityImpl : IContactUtility
{
    //UC2 + UC7:Add contact with duplicate check
    public Contacts AddContact(List<Contacts> contacts)
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        //UC7:Duplicate check within same Address Book
        foreach (Contacts c in contacts)
        {
            if (c.IsSamePerson(firstName, lastName))
            {
                Console.WriteLine("Duplicate contact found");
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
        string phone = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();

        Console.WriteLine("Contact added successfully");
        return new Contacts(firstName, lastName, address, city, state, zip, phone, email);
    }

    //UC3:Edit existing contact
    public void EditContact(List<Contacts> contacts)
    {
        Console.WriteLine("Enter First Name to edit:");
        string name = Console.ReadLine();

        foreach (Contacts c in contacts)
        {
            if (c.GetFirstName().Equals(name))
            {
                Console.WriteLine("Enter new City:");
                c.SetCity(Console.ReadLine());
                Console.WriteLine("Contact updated");
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }

    //UC4:Delete contact
    public void DeleteContact(List<Contacts> contacts)
    {
        Console.WriteLine("Enter First Name to delete:");
        string name = Console.ReadLine();

        contacts.RemoveAll(c => c.GetFirstName().Equals(name));
        Console.WriteLine("Delete operation completed");
    }

    //UC5:Show all contacts
    public void ShowAllContacts(List<Contacts> contacts)
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available");
            return;
        }

        foreach (Contacts c in contacts)
        {
            Console.WriteLine("Name: " + c.GetFullName());
            Console.WriteLine("Address: " + c.GetAddressDetails());
            Console.WriteLine("Phone: " + c.GetPhoneNumber());
            Console.WriteLine("Email: " + c.GetEmail());
            Console.WriteLine();
        }
    }

    //UC8:Search contacts by city or state
    public void SearchByCityOrState(Dictionary<string, AddressBook> addressBooks)
    {
        Console.WriteLine("Enter City or State:");
        string value = Console.ReadLine();

        foreach (AddressBook book in addressBooks.Values)
        {
            foreach (Contacts c in book.contacts)
            {
                if (c.GetAddressDetails().Contains(value))
                {
                    Console.WriteLine(c.GetFullName() + " (" + book.BookName + ")");
                }
            }
        }
    }

    //UC9:View persons by city or state
    public void ViewPersonsByCityOrState(Dictionary<string, AddressBook> addressBooks)
    {
        SearchByCityOrState(addressBooks);
    }

    //UC10:Count persons by city or state
    public void CountByCityOrState(Dictionary<string, AddressBook> addressBooks)
    {
        Console.WriteLine("Enter City or State:");
        string value = Console.ReadLine();
        int count = 0;

        foreach (AddressBook book in addressBooks.Values)
        {
            foreach (Contacts c in book.contacts)
            {
                if (c.GetAddressDetails().Contains(value))
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Total Persons: " + count);
    }

    //UC11:Sort contacts alphabetically by name
    public void SortContactsByName(List<Contacts> contacts)
    {
        contacts.Sort((a, b) => a.GetFullName().CompareTo(b.GetFullName()));
        Console.WriteLine("Contacts sorted by name");
    }

    //UC12:Sort contacts by city/state/zip
    public void SortContactsByCityStateOrZip(List<Contacts> contacts)
    {
        contacts.Sort((a, b) => a.GetAddressDetails().CompareTo(b.GetAddressDetails()));
        Console.WriteLine("Contacts sorted by address");
    }
}
