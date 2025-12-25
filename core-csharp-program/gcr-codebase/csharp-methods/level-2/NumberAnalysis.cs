using System;

public class NumberAnalysis
{
	//Method to check positive or negative
	static int CheckSign(int number){
		if(number>0){
			return 1;
		}
		else if(number<0){
			return -1;
		}
		else{
			return 0;
		}
	}



	//Method to check even or odd
	static bool IsEven(int number){
		if(number%2==0){
			return true;
		}
		
		else{
			return false;
		}
	}

	//Method to compare two numbers
	static int CompareNumbers(int a,int b){
		if(a>b){
			return 1;
		}
		
		else if(a<b){
			return -1;
		}
		
		else{
			return 0;
		}
	}


	static void Main(string[] args)
	{
		int[] numbers=new int[5];
		//Take input from user
		for(int i=0;i<numbers.Length;i++){		{
			Console.WriteLine("Enter number:");
			numbers[i]=Convert.ToInt32(Console.ReadLine());
		}

		//Analyze numbers
		for(int i=0;i<numbers.Length;i++){
			int sign=CheckSign(numbers[i]);

			if(sign>0){
				Console.WriteLine("Positive");
				if(IsEven(numbers[i])){
					Console.WriteLine("Even");
				}
				else{
					Console.WriteLine("Odd");
				}
			}
			
			else if(sign<0){
				Console.WriteLine("Negative");
			}
			else{
				Console.WriteLine("Zero");
			}
		}


		//Compare first and last
		int compare=CompareNumbers(numbers[0],numbers[numbers.Length-1]);
		if(compare>0){
			Console.WriteLine("First is greater");
		}
		
		else if(compare<0){
			Console.WriteLine("Last is greater");
		}
		
		else{
			Console.WriteLine("Both are equal");
		}
	}
}
