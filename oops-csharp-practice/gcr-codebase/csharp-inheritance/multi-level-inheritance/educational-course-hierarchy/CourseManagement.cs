using System;

class CourseManagement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter course name:");
        string courseName = Console.ReadLine();
        Console.WriteLine("Enter duration in weeks:");
        int duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter platform:");
        string platform = Console.ReadLine();
        Console.WriteLine("Is course recorded? true/false:");
        bool isRecorded = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter course fee:");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter discount:");
        double discount = Convert.ToDouble(Console.ReadLine());

        Course course = new PaidOnlineCourse(courseName, duration, platform, isRecorded, fee, discount);

        Console.WriteLine("Course Details:");
        course.DisplayInfo();
    }
}
