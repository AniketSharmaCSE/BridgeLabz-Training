using System;

public class StudentGrades2D
{
	static void Main(string[] args)
	{
		//input number of students
		Console.WriteLine("Enter number of students: ");
		int n = Convert.ToInt32(Console.ReadLine());

		//declare 2D array for marks, 1D array for percentage and grade
		int[,] marks = new int[n, 3];
		double[] percentage = new double[n];
		string[] grade = new string[n];

		//input marks from user
		for (int i = 0; i < n; i++){
			for (int j = 0; j < 3; j++){
				marks[i, j] = Convert.ToInt32(Console.ReadLine());
				if (marks[i, j] < 0){
					i--;
					break;
				}
			}
		}

		//calculate percentage and grade
		for (int i = 0; i < n; i++){
			percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

			if (percentage[i] >= 90)
				grade[i] = "A";
			else if (percentage[i] >= 75)
				grade[i] = "B";
			else
				grade[i] = "C";
		}

		//print the result
		for (int i = 0; i < n; i++){
			Console.WriteLine(percentage[i] + " " + grade[i]);
		}
	}
}
