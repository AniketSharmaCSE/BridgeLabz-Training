using System;

public class NaturalNumberSum
{
	//Method to find sum using recursion
	static int RecursiveSum(int n){
		if(n==0){
			return 0;
		}
		else{
			return n+RecursiveSum(n-1);
		}
	}



	//Method to find sum using formula
	static int FormulaSum(int n){
		return n*(n+1)/2;
	}




	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter number: ");
		int n=Convert.ToInt32(Console.ReadLine());

		int sum1=RecursiveSum(n);
		int sum2=FormulaSum(n);
		
		//Print the result
		Console.WriteLine("Recursive Sum = "+sum1);
		Console.WriteLine("Formula Sum = "+sum2);
	}
}
