using System;

public class DataScientist : JobRole
{
    public DataScientist(string name) : base(name)
    {
    }

    public override void Screen()
    {
        Console.WriteLine(CandidateName + " screened for Data Scientist role");
    }
}
