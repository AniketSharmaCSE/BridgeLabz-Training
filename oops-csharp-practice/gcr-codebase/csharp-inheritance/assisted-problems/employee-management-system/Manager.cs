using System;

class Manager : Employee
{
    public int TeamSize;

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    //Override to display manager specific details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}
