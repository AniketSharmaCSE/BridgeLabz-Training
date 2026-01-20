using System;

public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer(string name) : base(name)
    {
    }

    public override void Screen()
    {
        Console.WriteLine(CandidateName + " screened for Software Engineer role");
    }
}
