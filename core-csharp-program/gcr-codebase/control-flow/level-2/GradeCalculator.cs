using System;

public class GradeCalculator
{
    static void Main(string[] args)
    {
        //Ask marks for subjects
        Console.WriteLine("Enter marks in Physics: ");
        double physics = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter marks in Chemistry: ");
        double chemistry = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter marks in Maths: ");
        double maths = Convert.ToDouble(Console.ReadLine());


        //Calculate percentage
        double average = (physics + chemistry + maths) / 3;

        //Print grade
        Console.WriteLine("Average Marks: " + average);

        if (average >= 75)
        {
            Console.WriteLine("Grade: A, Remark: Excellent");
        }
        else if (average >= 60)
        {
            Console.WriteLine("Grade: B, Remark: Good");
        }
        else if (average >= 40)
        {
            Console.WriteLine("Grade: C, Remark: Pass");
        }
        else
        {
            Console.WriteLine("Grade: F, Remark: Fail");
        }
    }
}
