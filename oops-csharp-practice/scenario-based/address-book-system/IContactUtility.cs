public interface IContactUtility
{
    //UC2
    Contacts AddContact();

    //UC3
    void EditContact(Contacts[] contacts, int count);

    //UC4
    int DeleteContact(Contacts[] contacts, int count);

    //UC5
    void ShowAllContacts(Contacts[] contacts, int count);
}
