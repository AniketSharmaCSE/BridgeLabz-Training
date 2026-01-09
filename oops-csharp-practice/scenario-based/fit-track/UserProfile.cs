using System;

class UserProfile
{
    public string Name;
    public int Age;

    public UserProfile(string name, int age)
    {
        Name = name;
        Age = age;
    }

    //Method to display user details
    public void DisplayUser()
    {
        Console.WriteLine("User Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
