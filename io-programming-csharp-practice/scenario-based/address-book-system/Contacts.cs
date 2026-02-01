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

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetCity()
    {
       return city;
    }

    public string GetState()
    {
        return state;
    }

    public string GetZip()
    {
        return zip;
    }


    //UC7:Check duplicate contact by name
    public bool IsSamePerson(string fName, string lName)
    {
        return firstName.Equals(fName) && lastName.Equals(lName);
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


//UC13: Format to write to file
    public string ToFileString()
{
    return firstName + "|" + lastName + "|" + address + "|" + city + "|" + state + "|" + zip + "|" + phoneNumber + "|" + email;
}

public static Contacts FromFileString(string line)
{
    string[] parts = line.Split('|');

    return new Contacts(
        parts[0],
        parts[1],
        parts[2],
        parts[3],
        parts[4],
        parts[5],
        parts[6],
        parts[7]
    );
}

}
