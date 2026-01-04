using System;

class Course
{
    public string CourseName;
    public int Duration;

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }


    //Method to display course details
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " weeks");
    }
}
