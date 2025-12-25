using System;

public class Trigonometry
{
	//Method with trignometric functions
	static double[] CalculateTrigonometricFunctions(double angle){
		double radian=angle*Math.PI/180;
		double sin=Math.Sin(radian);
		double cos=Math.Cos(radian);
		double tan=Math.Tan(radian);
		return new double[]{sin,cos,tan};
		
	}

	static void Main(string[] args)
	{
		//Ask user for angle in degrees
		Console.WriteLine("Enter angle in degrees:");
		double angle=Convert.ToDouble(Console.ReadLine());

		//Call method to calculate
		double[] result=CalculateTrigonometricFunctions(angle);

		//Print all the results
		Console.WriteLine("Sin = "+result[0]);
		Console.WriteLine("Cos = "+result[1]);
		Console.WriteLine("Tan = "+result[2]);
	}
}
