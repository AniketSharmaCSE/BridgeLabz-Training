using System;
using System.Collections.Generic;

public class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T resume)
    {
        resumes.Add(resume);
    }

    public void ProcessResumes()
    {
        foreach (T resume in resumes)
        {
            resume.Screen();
        }
    }
}
