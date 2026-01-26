using System.Collections.Generic;

public interface IContactUtility
{
    //UC2
    Contacts AddContact(List<Contacts> contacts);

    //UC3
    void EditContact(List<Contacts> contacts);

    //UC4
    void DeleteContact(List<Contacts> contacts);

    //UC5
    void ShowAllContacts(List<Contacts> contacts);

    //UC8
    void SearchByCityOrState(Dictionary<string, AddressBook> addressBooks);

    //UC9
    void ViewPersonsByCityOrState(Dictionary<string, AddressBook> addressBooks);

    //UC10
    void CountByCityOrState(Dictionary<string, AddressBook> addressBooks);

    //UC11
    void SortContactsByName(List<Contacts> contacts);

    //UC12
    void SortContactsByCityStateOrZip(List<Contacts> contacts);
}
