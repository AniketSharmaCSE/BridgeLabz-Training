using System;

public class NumberCheckerAdvanced
{
	//Method to count digits
	static int CountDigits(int number){
		int count=0;
		while(number!=0){
			
			count++;
			number/=10;
		}
		
		return count;
	}
	

	//Method to store digits
	static int[] GetDigits(int number){
		int count=CountDigits(number);
		int[] digits=new int[count];
		for(int i=count-1;i>=0;i--){
			digits[i]=number%10;
			number/=10;
		}
		
		return digits;
	}

	//Method to find sum of digits
	static int FindDigitSum(int[] digits){
		int sum=0;
		
		for(int i=0;i<digits.Length;i++){
			sum+=digits[i];
		}
		
		return sum;
		
	}


	//Method to find sum of squares of digits
	static double FindSquareSum(int[] digits){
		double sum=0;
		
		for(int i=0;i<digits.Length;i++){
			sum+=Math.Pow(digits[i],2);
		}
		return sum;
	
	}


	//Method to check Harshad number
	static bool IsHarshad(int number,int sum){
		if(number%sum==0){
			return true;
		}
		else{
			return false;
		}
	}

	//Main method
	static void Main(string[] args)
	{
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());

		int[] digits=GetDigits(number);
		int sum=FindDigitSum(digits);

		Console.WriteLine("Digit Sum = "+sum);
		Console.WriteLine("Sum of Squares = "+FindSquareSum(digits));
		Console.WriteLine("Harshad = "+IsHarshad(number,sum));
	}
}
