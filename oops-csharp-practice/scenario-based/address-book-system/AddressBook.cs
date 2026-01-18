public class AddressBook
{
    public string BookName;
    public Contacts[] contacts;
    public int contactCount;

    public AddressBook(string bookName)
    {
        BookName = bookName;
        contacts = new Contacts[100];
        contactCount = 0;
    }
}
