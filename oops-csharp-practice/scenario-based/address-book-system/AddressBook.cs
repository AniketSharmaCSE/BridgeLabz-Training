using System.Collections.Generic;

public class AddressBook
{
    //UC6:Each Address Book has unique name
    public string BookName;

    //UC5 + UC6:Collection of contacts
    public List<Contacts> contacts;

    public AddressBook(string bookName)
    {
        BookName = bookName;
        contacts = new List<Contacts>();
    }
}
