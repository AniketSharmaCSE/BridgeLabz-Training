using System;

public class DuplicateContactException : Exception
{
    public DuplicateContactException(string message) : base(message) { }
}

public class ContactNotFoundException : Exception
{
    public ContactNotFoundException(string message) : base(message) { }
}

public class InvalidChoiceException : Exception
{
    public InvalidChoiceException(string message) : base(message) { }
}

public class EmptyInputException : Exception
{
    public EmptyInputException(string message) : base(message) { }
}

public class AddressBookNotFoundException : Exception
{
    public AddressBookNotFoundException(string message) : base(message) { }
}

public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string message) : base(message) { }
}
