using System;

public class District
{
    private string name;
    private Student[] students;

    public District(string name, Student[] students)
    {
        this.name = name;
        this.students = students;
    }

    public Student[] GetStudents()
    {
        return students;
    }
}
