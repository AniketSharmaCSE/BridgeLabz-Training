using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    //Method to display basic employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}
