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

    //UC8
    void SearchByCityOrState(AddressBook[] addressBooks, int bookCount);

    //UC9
    void ViewPersonsByCityOrState(AddressBook[] addressBooks, int bookCount);

    //UC10
    void CountByCityOrState(AddressBook[] addressBooks, int bookCount);

    //UC11
    void SortContactsByName(Contacts[] contacts, int count);

	//UC12
	void SortContactsByCityStateOrZip(Contacts[] contacts, int count);

}
