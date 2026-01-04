using System;

class Department
{
    public string Name;

    public Department(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Department: " + Name);
    }
}
