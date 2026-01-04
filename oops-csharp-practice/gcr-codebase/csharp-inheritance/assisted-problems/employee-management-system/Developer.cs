using System;

class Developer : Employee
{
    public string ProgrammingLanguage;

    public Developer(string name, int id, double salary, string language)
        : base(name, id, salary)
    {
        ProgrammingLanguage = language;
    }

    //Override to display developer specific details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}
