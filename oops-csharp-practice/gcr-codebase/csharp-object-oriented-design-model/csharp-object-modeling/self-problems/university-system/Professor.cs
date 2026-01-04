using System;

class Professor
{
    public string Name;

    public Professor(string name)
    {
        Name = name;
    }

    public void AssignProfessor(Course course)
    {
        course.AssignedProfessor = this;
        Console.WriteLine(Name + " assigned to " + course.Name);
    }
}
