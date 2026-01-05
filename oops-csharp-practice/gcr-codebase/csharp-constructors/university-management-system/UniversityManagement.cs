using System;

public class UniversityManagement
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter roll number:");
        int roll = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter CGPA:");
        double cgpa = Convert.ToDouble(Console.ReadLine());


        PostgraduateStudent student = new PostgraduateStudent(roll, name, cgpa);

        student.DisplayStudentName();


        Console.WriteLine("Current CGPA: " + student.GetCGPA());
        Console.WriteLine("Enter new CGPA:");
        double newCgpa = Convert.ToDouble(Console.ReadLine());

        student.SetCGPA(newCgpa);
        Console.WriteLine("Updated CGPA: " + student.GetCGPA());
    
	}
}
