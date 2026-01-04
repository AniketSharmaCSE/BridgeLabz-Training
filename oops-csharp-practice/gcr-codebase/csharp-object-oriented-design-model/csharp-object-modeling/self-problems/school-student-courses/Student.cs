using System;

public class Student
{
    string name;
    Course[] courses;
    int courseCount = 0;

    //Student created independently
    public Student(string name, int maxCourses)
    {
        this.name = name;
        courses = new Course[maxCourses];
    }

    //Associates student with a course
    public void EnrollCourse(Course course)
    {
        courses[courseCount] = course;
        courseCount++;
        course.AddStudent(this);
    }

    //Shows courses enrolled by student
    public void DisplayCourses()
    {
        Console.WriteLine("Student: " + name);

        for (int i = 0; i < courseCount; i++)
        {
            Console.WriteLine("- " + courses[i].GetCourseName());
        }
    }

    public string GetName()
    {
        return name;
    }
}
