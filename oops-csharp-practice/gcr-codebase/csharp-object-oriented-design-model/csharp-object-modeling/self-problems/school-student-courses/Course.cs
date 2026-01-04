using System;

public class Course
{
    string courseName;
    Student[] students;
    int studentCount = 0;

    //Course created independently
    public Course(string courseName, int maxStudents)
    {
        this.courseName = courseName;
        students = new Student[maxStudents];
    }

    //Adds student reference to course
    public void AddStudent(Student student)
    {
        students[studentCount] = student;
        studentCount++;
    }

    //Shows students enrolled in this course
    public void DisplayStudents()
    {
        Console.WriteLine("Course: " + courseName);

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("- " + students[i].GetName());
        }
    }

    public string GetCourseName()
    {
        return courseName;
    }
}
