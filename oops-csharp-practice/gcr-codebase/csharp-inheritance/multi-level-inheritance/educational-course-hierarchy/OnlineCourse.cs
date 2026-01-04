using System;

class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    //Override to display online course details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Is Recorded: " + IsRecorded);
    }
}
