using System;

public class Student
{
    private int marks;
    private string districtName;

    public Student(int marks, string districtName)
    {
        this.marks = marks;
        this.districtName = districtName;
    }

    public int GetMarks()
    {
        return marks;
    }

    public string GetDistrictName()
    {
        return districtName;
    }
}
