using System;

public class NumberChecker
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
	

	//Method to store digits in array
	static int[] GetDigits(int number){
		int count=CountDigits(number);
		int[] digits=new int[count];

		for(int i=count-1;i>=0;i--){
			digits[i]=number%10;
			number/=10;
		}
		return digits;
	
	}

	//Method to check duck number
	static bool IsDuckNumber(int[] digits){
		for(int i=0;i<digits.Length;i++){
			if(digits[i]==0){
				return true;
			}
		}
		
		return false;
	}

	//Method to check armstrong number
	static bool IsArmstrong(int number,int[] digits){
		
		int sum=0;
		int power=digits.Length;

		for(int i=0;i<digits.Length;i++){
			sum+=Math.Pow(digits[i],power);
		}

		if(sum==number){
			return true;
		}
		
		else{
			return false;
		}
		
	}

	//Method to find largest and second largest
	static int[] FindLargestTwo(int[] digits){
		int largest=Int32.MinValue;
		int secondLargest=Int32.MinValue;

		
		for(int i=0;i<digits.Length;i++){
			if(digits[i]>largest){
				secondLargest=largest;
				largest=digits[i];
			}
			
			else if(digits[i]>secondLargest && digits[i]!=largest){
				secondLargest=digits[i];
			}
		}
		
		return new int[]{largest,secondLargest};
	}


	//Method to find smallest and second smallest
	static int[] FindSmallestTwo(int[] digits){
		int smallest=Int32.MaxValue;
		int secondSmallest=Int32.MaxValue;

		for(int i=0;i<digits.Length;i++){
			if(digits[i]<smallest){
				secondSmallest=smallest;
				smallest=digits[i];
			}
			else if(digits[i]<secondSmallest && digits[i]!=smallest){
				secondSmallest=digits[i];
			}
		}
		return new int[]{smallest,secondSmallest};
	}


	static void Main(string[] args)
	{
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());

		int[] digits=GetDigits(number);

		Console.WriteLine("Duck Number = "+IsDuckNumber(digits));
		Console.WriteLine("Armstrong = "+IsArmstrong(number,digits));

		int[] large=FindLargestTwo(digits);
		int[] small=FindSmallestTwo(digits);

		Console.WriteLine("Largest = "+large[0]+" Second Largest = "+large[1]);
		Console.WriteLine("Smallest = "+small[0]+" Second Smallest = "+small[1]);
	}
}
