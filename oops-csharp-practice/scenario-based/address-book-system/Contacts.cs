using System;

public class Contacts
{
    //UC1: Encapsulated class with attributes
    private string firstName;
    private string lastName;
    private string address;
    private string city;
    private string state;
    private string zip;
    private string phoneNumber;
    private string email;

    // Constructor to create a contact
    public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetAddressDetails()
    {
        return address + ", " + city + ", " + state + " - " + zip;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public string GetEmail()
    {
        return email;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    //UC3:Setter methods to edit
    public void SetAddress(string address)
    {
        this.address = address;
    }

    public void SetCity(string city)
    {
        this.city = city;
    }

    public void SetState(string state)
    {
        this.state = state;
    }

    public void SetZip(string zip)
    {
        this.zip = zip;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }


}
