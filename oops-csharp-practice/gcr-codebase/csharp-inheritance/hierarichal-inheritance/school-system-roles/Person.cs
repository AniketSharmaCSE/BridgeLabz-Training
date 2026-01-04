using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    //Method to display role
    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }
}
