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

    //UC13
    void SaveToFile(List<Contacts> contacts, string filePath);
    void LoadFromFile(List<Contacts> contacts, string filePath);

     //UC14
    void SaveToCsv(List<Contacts> contacts, string filePath);
    void LoadFromCsv(List<Contacts> contacts, string filePath);

    //UC15
    void SaveToJson(List<Contacts> contacts, string filePath);
    void LoadFromJson(List<Contacts> contacts, string filePath);

}
