using System;

public class School
{
    string schoolName;
    Student[] students;
    int studentCount = 0;

    //School aggregates students
    public School(string schoolName, int maxStudents)
    {
        this.schoolName = schoolName;
        students = new Student[maxStudents];
    }

    //Adds student to school
    public void AddStudent(Student student)
    {
        students[studentCount] = student;
        studentCount++;
    }

    //Displays all students in school
    public void DisplayStudents()
    {
        Console.WriteLine("School: " + schoolName);

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("- " + students[i].GetName());
        }
    }
}
