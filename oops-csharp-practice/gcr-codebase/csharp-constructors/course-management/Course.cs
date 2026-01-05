using System;

public class Course
{
    string courseName;
    int duration;
    double fee;

   
   //Class variable common for all courses
    static string instituteName = "ABC Institute";


    //Constructor to initialize course details
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    //method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration);
        Console.WriteLine("Fee: " + fee);
    }


    //method to update institute name
    public static void UpdateInstituteName(string name)
    {
        instituteName = name;
    }
}
