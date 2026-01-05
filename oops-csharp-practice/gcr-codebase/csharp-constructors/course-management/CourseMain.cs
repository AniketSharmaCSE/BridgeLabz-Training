using System;

public class CourseMain
{
    static void Main(string[] args)
    {
        //Updating institute name using class method
        Console.WriteLine("Enter institute name:");
        string institute = Console.ReadLine();
       
	   Course.UpdateInstituteName(institute);


        Console.WriteLine("Enter number of courses:");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
			
            //Taking user input for course details
            Console.WriteLine("Enter course name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter course duration:");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course fee:");
            double fee = Convert.ToDouble(Console.ReadLine());

            Course course = new Course(name, duration, fee);
            course.DisplayCourseDetails();
        }
    }
}
