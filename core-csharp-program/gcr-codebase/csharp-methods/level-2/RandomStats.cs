using System;

public class RandomStats
{
	//Method to generate 4 digit random numbers
	static int[] Generate4DigitRandomArray(int size){
		//Use radnom to generate random numbers
		Random r=new Random();
		int[] arr=new int[size];
	
		for(int i=0;i<size;i++){
			arr[i]=r.Next(1000,10000);
		}
		return arr;
	}

	//Method to find average min and max
	static double[] FindAverageMinMax(int[] numbers){
		int min=numbers[0];
		int max=numbers[0];
		int sum=0;

		for(int i=0;i<numbers.Length;i++){
			sum+=numbers[i];
			min=Math.Min(min,numbers[i]);
			max=Math.Max(max,numbers[i]);
		}

		double avg=(double)sum/numbers.Length;
		return new double[]{avg,min,max};
	}

	static void Main(string[] args)
	{
		int[] numbers=Generate4DigitRandomArray(5);
		double[] result=FindAverageMinMax(numbers);

		for(int i=0;i<numbers.Length;i++){
			Console.WriteLine(numbers[i]);
		}

		Console.WriteLine("Average = "+result[0]);
		Console.WriteLine("Min = "+result[1]);
		Console.WriteLine("Max = "+result[2]);
	}
}
