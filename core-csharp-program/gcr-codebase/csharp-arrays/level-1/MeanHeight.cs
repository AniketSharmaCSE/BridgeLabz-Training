using System;

public class MeanHeight
{
	static void Main(string[] args)
	{
		// Declare array to store heights
		double[] heights = new double[11];

		// Variable to store sum
		double sum = 0;

		// Take input for height
		Console.WriteLine("Enter height of the players: ");
		for (int i = 0; i < heights.Length; i++){
			heights[i] = Convert.ToDouble(Console.ReadLine());
			sum = sum + heights[i];
		}


		// Calculate mean height
		double mean = sum / heights.Length;

		// Display mean height
		Console.WriteLine("Mean Height = " + mean);
	}
}
