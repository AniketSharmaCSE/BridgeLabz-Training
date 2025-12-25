using System;

public class PrimeRange
{
	//Method to check prime number
	static bool IsPrime(int number){
		if(number<=1){
			return false;
		}
		
		for(int i=2;i<=number/2;i++){
			if(number%i==0){
				return false;
			}
		}
		return true;
	}


	//Method to print primes in range
	static void PrintPrimeRange(int start,int end){
		for(int i=start;i<=end;i++){
			if(IsPrime(i)){
				Console.Write(i+" ");
			}
		}
	}


	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter start:");
		int start=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter end:");
		int end=Convert.ToInt32(Console.ReadLine());

		PrintPrimeRange(start,end);
	}
}
