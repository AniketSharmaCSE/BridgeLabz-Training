using System;

public class StudentGrades
{
	static void Main(string[] args)
	{
		//input number of students
		Console.WriteLine("Enter number of students:");
		int n = Convert.ToInt32(Console.ReadLine());

		//declare array for subjects, percentage and grade
		int[] physics = new int[n];
		int[] chemistry = new int[n];
		int[] maths = new int[n];
		double[] percentage = new double[n];
		string[] grade = new string[n];

		//input marks for each subject
		for (int i = 0; i < n; i++){
			Console.WriteLine("Enter physics marks:");
			physics[i] = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter chemistry marks:");
			chemistry[i] = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter maths marks:");
			maths[i] = Convert.ToInt32(Console.ReadLine());

			//Check for conditions
			if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0){
				i--;
			}
			else{
				percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;

				if (percentage[i] >= 90)
					grade[i] = "A";
				else if (percentage[i] >= 75)
					grade[i] = "B";
				else
					grade[i] = "C";
			}
		}

		//Print thr result
		for (int i = 0; i < n; i++){
			Console.WriteLine(percentage[i] + " " + grade[i]);
		}
	}
}
