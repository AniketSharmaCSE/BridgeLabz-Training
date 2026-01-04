using System;

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }

    public void EnrollCourse(Course course)
    {
        Console.WriteLine(Name + " enrolled in " + course.Name);
    }
}
