using System;

class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Patient(string name, int age)
    {
        Name = name;
        Age = age;
    }

    //Method to display patient info
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
