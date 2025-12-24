using System;

public class DividingPens
{
    public static void Main(string[] args)
    {
		//define number of pens and number of students
        int NumberOfPens = 14;
        int NumberOfStudents = 3;

		//Calculated number of distributed pens
        int DistributedPens = NumberOfPens/NumberOfStudents;
		//Calculate number of remaining pens
        int RemainingPens = NumberOfPens%NumberOfStudents;

		//print the result
        Console.WriteLine("The Pen Per Student is " + DistributedPens +" and the remaining pen not distributed is " + RemainingPens);
    }
}
