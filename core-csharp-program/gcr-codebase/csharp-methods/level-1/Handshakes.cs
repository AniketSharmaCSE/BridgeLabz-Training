using System;

public class Handshakes
{
	static int CalculateHandshakes(int students){
		return (students*(students-1))/2;
	}

	static void Main(string[] args)
	{
		//Ask user for number of students
		Console.WriteLine("Enter number of students:");
		int students=Convert.ToInt32(Console.ReadLine());
		int result=CalculateHandshakes(students);

		//Print total handshakes
		Console.WriteLine("Maximum handshakes = "+result);
	}
}
