using System;

public class ExamCourse : CourseType
{
    public ExamCourse(string courseName) : base(courseName)
    {
    }

    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " evaluated by written exam");
    }
}
