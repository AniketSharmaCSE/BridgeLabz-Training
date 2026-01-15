public interface IContactUtility
{
    //UC2: method to add contacts
    Contacts AddContact();

    //Method to show contact details
    void ShowContact(Contacts contact);

    //UC3: method to edit existing contact
    void EditContact(Contacts contact);

    //UC4: method to delete existing contact
    Contacts DeleteContact(Contacts contact);
}
