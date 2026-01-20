using System;

public abstract class JobRole
{
    public string CandidateName { get; set; }

    public JobRole(string candidateName)
    {
        CandidateName = candidateName;
    }

    public abstract void Screen();
}
