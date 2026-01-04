using System;

class Staff : Person
{
    public string Department;

    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    //Override to display staff role
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Department: " + Department);
    }
}
