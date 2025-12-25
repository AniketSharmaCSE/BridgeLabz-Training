using System;

public class SumOfNaturalNumbers
{
	//Method to Calculate Sum
	static int CalculateSum(int n){
		int sum=0;
		//for loop to calculate sum
		for(int i=1;i<=n;i++){
			sum=sum+i;
		}
		return sum;
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter a number:");
		int n=Convert.ToInt32(Console.ReadLine());

		//Call method to find sum
		int result=CalculateSum(n);

		//Print result
		Console.WriteLine("Sum = "+result);
	}
}
