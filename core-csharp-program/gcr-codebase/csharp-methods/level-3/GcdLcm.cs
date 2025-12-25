using System;

public class GcdLcm
{
	//Method to find gcd of two numbers
	static int FindGcd(int a,int b){
		while(b!=0){
			int temp=b;
			b=a%b;
			a=temp;
		}
		return a;
	}


	//Method to find lcm of two numbers
	static int FindLcm(int a,int b){
		return (a*b)/FindGcd(a,b);
	}


	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter first number:");
		int a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number:");
		int b=Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("GCD = "+FindGcd(a,b));
		Console.WriteLine("LCM = "+FindLcm(a,b));
	}
}
