using System;

public class AthleteRun
{	
	//Define method to calculate rounds
	static double CalculateRounds(double a,double b,double c){
		double perimeter=a+b+c;
		return 5000/perimeter;
	}

	static void Main(string[] args)
	{
		//Take sides of triangular park
		Console.WriteLine("Enter side 1:");
		double a=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter side 2:");
		double b=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter side 3:");
		double c=Convert.ToDouble(Console.ReadLine());

		//Call the function
		double rounds=CalculateRounds(a,b,c);

		//Print the result
		Console.WriteLine("Rounds needed = "+rounds);
	}
}
