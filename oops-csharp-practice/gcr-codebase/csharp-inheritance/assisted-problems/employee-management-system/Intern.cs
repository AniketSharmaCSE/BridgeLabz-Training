using System;

class Intern : Employee
{
    public string InternshipDuration;

    public Intern(string name, int id, double salary, string duration)
        : base(name, id, salary)
    {
        InternshipDuration = duration;
    }

    //Override to display intern specific details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}
