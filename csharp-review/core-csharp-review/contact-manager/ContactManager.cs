using System;

public class ContactManager
{
    static string[,] contacts = new string[50, 2];
    static int count = 0;
    static int maxSize = 50;


    //Add Contact
    static void AddContact()
    {
        if (count >= maxSize)
        {
            Console.WriteLine("Contact list is full");
            return;
        }

        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter phone number: ");
        string phone = Console.ReadLine();
        if (phone.Length < 10 || phone.Length > 10) {
            Console.WriteLine("Invalid number");
            return;
        }

        contacts[count, 0] = name;
        contacts[count, 1] = phone;
        count++;

        Console.WriteLine("Contact added successfully");
    }

    // Method to update a contact
    static void UpdateContact()
    {
        Console.Write("Enter name to update: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i, 0] == name)
            {
                Console.Write("Enter new phone number: ");
                string updated = Console.ReadLine();
                if (updated.Length < 10 || updated.Length > 10)
                {
                    Console.WriteLine("Invalid number");
                    return;
                }
                else
                {
                    contacts[i, 1] = updated;
                    Console.WriteLine("Contact updated");
                }
                
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }

    static void searchContact()
    {
        Console.WriteLine("Enter name to search for: ");
        String name = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i, 0].ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine("Name: " + contacts[i, 0]);
                Console.WriteLine("Phone: " + contacts[i, 1]);
                found = true;
            }

        }
        if (found == false) {
            Console.WriteLine("Contact Not Found");
        }

    }
    static void DeleteContact()
    {
        Console.WriteLine("Enter name to delete: ");
        string name = Console.ReadLine();

        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i, 0] == name)
            {
                index = i;
                break;
            }
        }
        if (index == -1)
        {
            Console.WriteLine("Contact not found");


        }
        else
        {
            for (int i = 0; i < count - 1; i++)
            {
                contacts[i, 0] = contacts[i + 1, 0];
                contacts[i, 1] = contacts[i + 1, 1];
            }
            contacts[count - 1, 0] = null;
            contacts[count - 1, 1] = null;
            count--;

            Console.WriteLine("Contact Deleted");
        }
    }

    static void updateContact()
    {
        Console.WriteLine("Enter name of contact to be updated");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i, 0] == name)
            {
                Console.WriteLine("Old Number: " + contacts[i, 1]);
                Console.WriteLine("Enter the updated phone number: ");
                contacts[i, 1] = Console.ReadLine();

                Console.WriteLine("Contact Updated");
                Console.WriteLine("Updated Number: " + contacts[i, 1]);

                return;
            }
            else {
                Console.WriteLine("Contact not found");
            }
        }
    }

            static void Main(string[] args)
            {
                bool exit = false;
                while (exit == false)
                {
                    Console.WriteLine("\n----Contacts Manager----");
                    Console.WriteLine("1. Add Contact");
                    Console.WriteLine("2. Delete Contact");
                    Console.WriteLine("3. Update Contact");
                    Console.WriteLine("4. Search Contact");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Select from the options");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        AddContact();
                    }
                    else if (choice == 2)
                    {
                        DeleteContact();
                    }
                    else if (choice == 3)
                    {
                        updateContact();
                    }
                    else if (choice == 4)
                    {
                        searchContact();
                    }
                    else if (choice == 5)
                    {
                        exit = true;
                        Console.WriteLine("Exiting...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");
                    }

                }

            }
        }
    