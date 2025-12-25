using System;

public class FootballHeights
{
	//Method to generate random heights for players
	static int[] GenerateHeights(int size){
		Random r=new Random();
		int[] heights=new int[size];

		for(int i=0;i<heights.Length;i++){
			heights[i]=r.Next(150,251);
		}
		return heights;
	}
	

	//Method to find sum of heights
	static int FindSum(int[] heights){
		int sum=0;
		for(int i=0;i<heights.Length;i++){
			sum+=heights[i];
		}
		return sum;
	
}

	//Method to find mean height
	static double FindMean(int[] heights){
		return (double)FindSum(heights)/heights.Length;
	}
	

	//Method to find shortest height
	static int FindShortest(int[] heights){
		int min=heights[0];
		for(int i=1;i<heights.Length;i++){
			if(heights[i]<min){
				min=heights[i];
			}
		}
		return min;
	}
	

	//Method to find tallest height
	static int FindTallest(int[] heights){
		int max=heights[0];
		for(int i=1;i<heights.Length;i++){
			if(heights[i]>max){
				max=heights[i];
			}
		}
		return max;
	}
	
	

	static void Main(string[] args)
	{
		int[] heights=GenerateHeights(11);

		Console.WriteLine("Heights:");
		for(int i=0;i<heights.Length;i++){
			Console.Write(heights[i]+" ");
		}

		Console.WriteLine("\nShortest = "+FindShortest(heights));
		Console.WriteLine("Tallest = "+FindTallest(heights));
		Console.WriteLine("Mean = "+FindMean(heights));
	}
}
