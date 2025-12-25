using System;

public class Quadratic
{
	//Method to find roots of quadratic equation
	static double[] FindRoots(double a,double b,double c){
		double delta=(b*b)-(4*a*c);

		if(delta<0){
			return new double[0];
		}
		else if(delta==0){
			return new double[]{-b/(2*a)};
		}
		else{
			double r1=(-b+Math.Sqrt(delta))/(2*a);
			double r2=(-b-Math.Sqrt(delta))/(2*a);
			return new double[]{r1,r2};
		}
	}

	static void Main(string[] args)
	{
		//Input values of a, b and c
		Console.WriteLine("Enter a:");
		double a=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter b:");
		double b=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter c:");
		double c=Convert.ToDouble(Console.ReadLine());

		//Invoke method to find roots
		double[] roots=FindRoots(a,b,c);

		if(roots.Length==0){
			Console.WriteLine("No real roots");
		}
		else{
			for(int i=0;i<roots.Length;i++){
				Console.WriteLine("Root = "+roots[i]);
			}
		}
	}
}
