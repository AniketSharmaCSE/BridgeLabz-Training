using System;

public class SimpleInterest
{
	static double CalculateSimpleInterest(double principal,double rate,double time){
		return (principal*rate*time)/100;
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter principal: ");
		double principal=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter rate: ");
		double rate=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter time: ");
		double time=Convert.ToDouble(Console.ReadLine());

		//Call method to calculate simple interest
		double result=CalculateSimpleInterest(principal,rate,time);

		//Print the result
		Console.WriteLine("The Simple Interest is "+result+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
	}
}
