using System;

public class Copy2DTo1D
{
	static void Main(string[] args)
	{
		//Take rows and columns input
		Console.WriteLine("Enter number of rows:");
		int rows = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter number of columns:");
		int columns = Convert.ToInt32(Console.ReadLine());

		//Declare 2D array
		int[,] matrix = new int[rows, columns];

		//Declare 1D array
		int[] array = new int[rows * columns];
		int index = 0;

		//Take input for 2D array
		Console.WriteLine("Enter elements:");
		for (int i = 0; i < rows; i++){
			for (int j = 0; j < columns; j++){
				matrix[i, j] = Convert.ToInt32(Console.ReadLine());
				array[index] = matrix[i, j];
				index++;
			}
		}



		//Print 1D array
		Console.WriteLine("1D Array:");
		for (int i = 0; i < array.Length; i++){
			Console.Write(array[i] + " ");
		}
	}
}
