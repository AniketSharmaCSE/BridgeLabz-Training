using System;

public class FriendsInfo
{
	static void Main(string[] args)
	{
		//arrays for age and height
		int[] age = new int[3];
		double[] height = new double[3];


		//take input using for loop 
		for (int i = 0; i < 3; i++){
			Console.WriteLine("Enter age:");
			age[i] = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter height:");
			height[i] = Convert.ToDouble(Console.ReadLine());
		}


		int youngest = age[0];
		double tallest = height[0];

		//find youngest and tallest using conditions
		for (int i = 1; i < 3; i++){
			if (age[i] < youngest)
				youngest = age[i];

			if (height[i] > tallest)
				tallest = height[i];
		}

		Console.WriteLine("Youngest Age = " + youngest);
		Console.WriteLine("Tallest Height = " + tallest);
	}
}
