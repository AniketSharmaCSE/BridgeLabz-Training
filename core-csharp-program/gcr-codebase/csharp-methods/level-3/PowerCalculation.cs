using System;

public class PowerCalculation
{
	//Method to calculate power of a number
	static int CalculatePower(int baseValue,int exponent){
		int result=1;
		for(int i=1;i<=exponent;i++){
			result*=baseValue;
		}
		
		return result;
	}
	

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter base:");
		int baseValue=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter exponent:");
		int exponent=Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Result = "+CalculatePower(baseValue,exponent));
	}
}
