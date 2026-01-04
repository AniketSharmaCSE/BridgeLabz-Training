using System;

class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    //Override to display paid course details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Discount: " + Discount);
    }
}
