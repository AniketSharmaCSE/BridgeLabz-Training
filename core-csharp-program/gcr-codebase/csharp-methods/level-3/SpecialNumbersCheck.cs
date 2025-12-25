using System;

public class SpecialNumberChecks
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


	//Method to check neon number
	static bool IsNeon(int number){
		int square=number*number;
		int sum=0;

		while(square!=0){
			sum+=square%10;
			square/=10;
		}

		if(sum==number){
			return true;
		}
		else{
			return false;
		}
	}


	//Method to check spy number
	static bool IsSpy(int number){
		int sum=0;
		int product=1;

		while(number!=0){
			int digit=number%10;
			sum+=digit;
			product*=digit;
			number/=10;
		}

		if(sum==product){
			return true;
		}
		else{
			return false;
		}
	}


	//Method to check automorphic number
	static bool IsAutomorphic(int number){
		int square=number*number;
		int temp=number;

		while(temp!=0){
			if(temp%10!=square%10){
				return false;
			}
			temp/=10;
			square/=10;
		}
		return true;
	}



	//Method to check buzz number
	static bool IsBuzz(int number){
		if(number%7==0 || number%10==7){
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

		Console.WriteLine("Prime = "+IsPrime(number));
		Console.WriteLine("Neon = "+IsNeon(number));
		Console.WriteLine("Spy = "+IsSpy(number));
		Console.WriteLine("Automorphic = "+IsAutomorphic(number));
		Console.WriteLine("Buzz = "+IsBuzz(number));
	}
}
