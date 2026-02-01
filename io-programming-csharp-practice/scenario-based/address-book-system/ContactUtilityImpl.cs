using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class ContactUtilityImpl : IContactUtility
{
    //UC2 + UC7:Add contact with duplicate check
    public Contacts AddContact(List<Contacts> contacts)
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            throw new EmptyInputException("First name or last name cannot be empty");
        }

        //UC7:Duplicate check within same Address Book
        foreach (Contacts c in contacts)
        {
            if (c.IsSamePerson(firstName, lastName))
            {
                throw new DuplicateContactException("Duplicate contact found");
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
        if (phone.Length < 10 || phone.Length>10)
        {
            throw new InvalidPhoneNumberException("Phone number is not valid");
        }

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
                int choice = 0;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("What do you want to edit?");
                    Console.WriteLine("1. Address");
                    Console.WriteLine("2. City");
                    Console.WriteLine("3. State");
                    Console.WriteLine("4. Zip");
                    Console.WriteLine("5. Phone Number");
                    Console.WriteLine("6. Email");
                    Console.WriteLine("0. Exit Edit Menu");

                    Console.WriteLine("Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new Address:");
                            c.SetAddress(Console.ReadLine());
                            Console.WriteLine("Address updated");
                            break;

                        case 2:
                            Console.WriteLine("Enter new City:");
                            c.SetCity(Console.ReadLine());
                            Console.WriteLine("City updated");
                            break;

                        case 3:
                            Console.WriteLine("Enter new State:");
                            c.SetState(Console.ReadLine());
                            Console.WriteLine("State updated");
                            break;

                        case 4:
                            Console.WriteLine("Enter new Zip:");
                            c.SetZip(Console.ReadLine());
                            Console.WriteLine("Zip updated");
                            break;

                        case 5:
                            Console.WriteLine("Enter new Phone Number:");
                            c.SetPhoneNumber(Console.ReadLine());
                            Console.WriteLine("Phone Number updated");
                            break;

                        case 6:
                            Console.WriteLine("Enter new Email:");
                            c.SetEmail(Console.ReadLine());
                            Console.WriteLine("Email updated");
                            break;

                        case 0:
                            Console.WriteLine("Exiting edit menu...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                } while (choice != 0);

                return;
            }
        }

        throw new ContactNotFoundException("Contact not found");
    }

    //UC4:Delete contact
    public void DeleteContact(List<Contacts> contacts)
    {
        Console.WriteLine("Enter First Name to delete:");
        string name = Console.ReadLine();

        int removed = contacts.RemoveAll(c => c.GetFirstName().Equals(name));

        if (removed == 0)
        {
            throw new ContactNotFoundException("Contact not found");
        }

        Console.WriteLine("Contact deleted successfully");
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
        Console.WriteLine("View by:");
        Console.WriteLine("1. City");
        Console.WriteLine("2. State");
        Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, List<Contacts>> map = new Dictionary<string, List<Contacts>>();

        foreach (AddressBook book in addressBooks.Values)
        {
            foreach (Contacts c in book.contacts)
            {
                string key = "";

                string[] parts = c.GetAddressDetails().Split(',');

                if (choice == 1)
                {
                    key = parts[1].Trim(); //City
                }
                else if (choice == 2)
                {
                    key = parts[2].Trim().Split('-')[0].Trim(); //State
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    return;
                }

                if (!map.ContainsKey(key))
                {
                    map.Add(key, new List<Contacts>());
                }

                map[key].Add(c);
            }
        }

        if (map.Count == 0)
        {
            Console.WriteLine("No contacts found");
            return;
        }

        foreach (var item in map)
        {
            Console.WriteLine();
            Console.WriteLine(item.Key + " :");

            foreach (Contacts c in item.Value)
            {
                Console.WriteLine("  " + c.GetFullName());
            }
        }
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
        Console.WriteLine("Sort by:");
        Console.WriteLine("1. City");
        Console.WriteLine("2. State");
        Console.WriteLine("3. Zip");
        Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            contacts.Sort((a, b) => a.GetCity().CompareTo(b.GetCity()));
            Console.WriteLine("Contacts sorted by City");
        }
        else if (choice == 2)
        {
            contacts.Sort((a, b) => a.GetState().CompareTo(b.GetState()));
            Console.WriteLine("Contacts sorted by State");
        }
        else if (choice == 3)
        {
            contacts.Sort((a, b) => a.GetZip().CompareTo(b.GetZip()));
            Console.WriteLine("Contacts sorted by Zip");
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }

    //UC13: Method to write in a file
    public void SaveToFile(List<Contacts> contacts, string filePath)
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (Contacts c in contacts)
        {
            writer.WriteLine(c.ToFileString());
        }
    }

    Console.WriteLine("Contacts saved to file successfully");
}

    //UC13: Method to read from file
    public void LoadFromFile(List<Contacts> contacts, string filePath)
{
    if (!File.Exists(filePath))
    {
        Console.WriteLine("File not found");
        return;
    }

    contacts.Clear();

    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Contacts c = Contacts.FromFileString(line);
            contacts.Add(c);
        }
    }

    Console.WriteLine("Contacts loaded from file successfully");
}

//UC14: Save contacts to CSV file
public void SaveToCsv(List<Contacts> contacts, string filePath)
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        //Header row
        writer.WriteLine("FirstName,LastName,Address,City,State,Zip,Phone,Email");

        foreach (Contacts c in contacts)
        {
            string line =
                c.GetFullName().Split(' ')[0] + "," +
                c.GetFullName().Split(' ')[1] + "," +
                c.GetAddressDetails().Split(',')[0] + "," +
                c.GetCity() + "," +
                c.GetState() + "," +
                c.GetZip() + "," +
                c.GetPhoneNumber() + "," +
                c.GetEmail();

            writer.WriteLine(line);
        }
    }

    Console.WriteLine("Contacts saved to CSV file successfully");
}

//UC14:Load contacts from CSV file
public void LoadFromCsv(List<Contacts> contacts, string filePath)
{
    if (!File.Exists(filePath))
    {
        Console.WriteLine("CSV file not found");
        return;
    }

    contacts.Clear();

    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        reader.ReadLine();

        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');

            Contacts c = new Contacts(
                parts[0],
                parts[1],
                parts[2],
                parts[3],
                parts[4],
                parts[5],
                parts[6],
                parts[7]
            );

            contacts.Add(c);
        }
    }

    Console.WriteLine("Contacts loaded from CSV file successfully");
}

//UC15:Save contacts to JSON file
public void SaveToJson(List<Contacts> contacts, string filePath)
{
    string jsonString = JsonSerializer.Serialize(contacts);
    File.WriteAllText(filePath, jsonString);
    Console.WriteLine("Contacts saved to JSON file successfully");
}

//UC15:Load contacts from JSON file
public void LoadFromJson(List<Contacts> contacts, string filePath)
{
    if (!File.Exists(filePath))
    {
        Console.WriteLine("JSON file not found");
        return;
    }

    string jsonString = File.ReadAllText(filePath);
    List<Contacts> loadedContacts = JsonSerializer.Deserialize<List<Contacts>>(jsonString);

    contacts.Clear();

    if (loadedContacts != null)
    {
        foreach (Contacts c in loadedContacts)
        {
            contacts.Add(c);
        }
    }

    Console.WriteLine("Contacts loaded from JSON file successfully");
}




}
