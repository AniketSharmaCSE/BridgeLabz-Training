using System;

public class EduResultsMain
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of districts: ");
        int districtCount = Convert.ToInt32(Console.ReadLine());

        District[] districts = new District[districtCount];
        int totalStudents = 0;

        for (int i = 0; i < districtCount; i++)
        {
            Console.Write("Enter district name: ");
            string districtName = Console.ReadLine();

            Console.Write("Enter number of students in " + districtName + ": ");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[studentCount];

            Console.WriteLine("Enter sorted marks for " + districtName + ":");
            for (int j = 0; j < studentCount; j++)
            {
                int marks = Convert.ToInt32(Console.ReadLine());
                students[j] = new Student(marks, districtName);
            }

            districts[i] = new District(districtName, students);
            totalStudents += studentCount;
        }

        // Combine all district students into one array
        Student[] allStudents = new Student[totalStudents];
        int index = 0;

        for (int i = 0; i < districtCount; i++)
        {
            Student[] districtStudents = districts[i].GetStudents();
            for (int j = 0; j < districtStudents.Length; j++)
            {
                allStudents[index] = districtStudents[j];
                index++;
            }
        }

        StateRankMerger merger = new StateRankMerger();
        merger.MergeSort(allStudents, 0, allStudents.Length - 1);

        Console.WriteLine("\nFinal State-wise Rank List:");
        for (int i = 0; i < allStudents.Length; i++)
        {
            Console.WriteLine(
                "Marks: " + allStudents[i].GetMarks() +
                " | District: " + allStudents[i].GetDistrictName()
            );
        }
    }
}
