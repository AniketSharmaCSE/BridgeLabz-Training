using System;

public class FibonacciSeries
{
	//Method to print fibonacci series
	static void PrintFibonacci(int n){
		int a=0;
		int b=1;

		for(int i=1;i<=n;i++){
			Console.Write(a+" ");
			int c=a+b;
			a=b;
			b=c;
		}
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter number of terms:");
		int n=Convert.ToInt32(Console.ReadLine());

		PrintFibonacci(n);
	}
}
