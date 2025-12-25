using System;

public class FriendsComparison
{
	//Method to find youngest age
	static int FindYoungest(int[] ages){
		int youngest=ages[0];
		for(int i=1;i<ages.Length;i++){
			if(ages[i]<youngest){
				youngest=ages[i];
			}
		}
		return youngest;
	}
	

	//Method to find tallest height
	static double FindTallest(double[] heights){
		double tallest=heights[0];
		for(int i=1;i<heights.Length;i++){
			if(heights[i]>tallest){
				tallest=heights[i];
			}
		}
		return tallest;
	
	}

	
	static void Main(string[] args)
	{
		//array to store age 
		int[] age=new int[3];
		//array to store heights
		double[] height=new double[3];

		//Take input from user for age and height
		for(int i=0;i<3;i++){
			Console.WriteLine("Enter age:");
			age[i]=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter height:");
			height[i]=Convert.ToDouble(Console.ReadLine());
		}
		
		//Call methods to print result
		Console.WriteLine("Youngest Age = "+FindYoungest(age));
		Console.WriteLine("Tallest Height = "+FindTallest(height));
	}
}
