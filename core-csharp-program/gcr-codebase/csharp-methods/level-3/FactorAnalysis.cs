using System;

public class FactorAnalysis
{
	//Method to find factors of a number
	static int[] FindFactors(int number){
		int count=0;
		
		for(int i=1;i<=number;i++){
			if(number%i==0){
				count++;
			}
		}

		int[] factors=new int[count];
		int index=0;

		for(int i=1;i<=number;i++){
			if(number%i==0){
				factors[index]=i;
				index++;
			}
		}
		return factors;
	}


	//Method to find prime factors
	static void PrintPrimeFactors(int number){
		for(int i=2;i<=number;i++){
			while(number%i==0){
				Console.Write(i+" ");
				number/=i;
			}
		}
	}


	//Method to check perfect number
	static bool IsPerfectNumber(int[] factors,int number){
		int sum=0;
		for(int i=0;i<factors.Length-1;i++){
			sum+=factors[i];
		}
		if(sum==number){
			return true;
		}
		else{
			return false;
		}
	}



	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());

		int[] factors=FindFactors(number);

		Console.WriteLine("Factors:");
		for(int i=0;i<factors.Length;i++){
			Console.Write(factors[i]+" ");
		}

		Console.WriteLine("\nPrime Factors:");
		PrintPrimeFactors(number);

		if(IsPerfectNumber(factors,number)){
			Console.WriteLine("\nPerfect Number");
		}
		else{
			Console.WriteLine("\nNot a Perfect Number");
		}
	}
}
