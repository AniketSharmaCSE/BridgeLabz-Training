using System;

public class PostgraduateStudent : Student
{
    //Constructor calling base class constructor
    public PostgraduateStudent(int rollNumber, string name, double cgpa) : base(rollNumber, name, cgpa)
    {
		
    }

    //Method to access protected member
    public void DisplayStudentName()
    {
        Console.WriteLine("Student Name: " + name);
    
	}

}

