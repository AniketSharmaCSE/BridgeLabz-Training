using System;

class Faculty
{
    public string Name;

    public Faculty(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Faculty: " + Name);
    }
}
