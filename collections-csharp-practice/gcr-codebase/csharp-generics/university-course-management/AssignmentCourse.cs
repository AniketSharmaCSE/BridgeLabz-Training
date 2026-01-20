using System;

public class AssignmentCourse : CourseType
{
    public AssignmentCourse(string courseName) : base(courseName)
    {
    }

    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " evaluated by assignments");
    }
}
