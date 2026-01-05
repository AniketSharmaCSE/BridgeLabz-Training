using System;

public class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    //Constructor to initialize student details
    public Student(int rollNumber, string name, double cgpa)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;

    }


    //Public method to get CGPA
    public double GetCGPA()
    {
        return cgpa;
    }
    //Public method to update CGPA
    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }
}
