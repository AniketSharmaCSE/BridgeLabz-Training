using System;

public class FactorsCalculation
{
	//Method to find factors of a number
	static int[] FindFactors(int number){
		
		//Count possible factors for the number
		int count=0;
		for(int i=1;i<=number;i++){
			if(number%i==0){
				count++;
			}
		}

		//Define new array to store factors
		int[] factors=new int[count];
		int index=0;

		//Calculate and store the factors
		for(int i=1;i<=number;i++){
			if(number%i==0){
				factors[index]=i;
				index++;
			}
		}
		return factors;
	}

	//Method to find sum of factors
	static int FindSum(int[] factors){
		//Using for loop to find sum
		int sum=0;
		for(int i=0;i<factors.Length;i++){
			sum+=factors[i];
		}
		return sum;
	}

	//Method to find product of factors
	static int FindProduct(int[] factors){
		//Using For loop o find multiples
		int product=1;
		for(int i=0;i<factors.Length;i++){
			product*=factors[i];
		}
		return product;
	}

	//Method to find sum of squares of factors
	static double FindSumOfSquares(int[] factors){
		double sum=0;
		//For loop with Math.pow to calculate sum of squares
		for(int i=0;i<factors.Length;i++){
			sum+=Math.Pow(factors[i],2);
		}
		return sum;
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());
		int[] factors=FindFactors(number);


		//Print the factors
		Console.WriteLine("Factors:");
		for(int i=0;i<factors.Length;i++){
			Console.Write(factors[i]+" ");
		}

		//Print the sume, product and sum of squares
		Console.WriteLine("\nSum = "+FindSum(factors));
		Console.WriteLine("Product = "+FindProduct(factors));
		Console.WriteLine("Sum of Squares = "+FindSumOfSquares(factors));
	}
}
