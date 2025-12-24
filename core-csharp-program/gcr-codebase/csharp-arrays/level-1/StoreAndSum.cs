using System;

public class StoreAndSum
{
	static void Main(string[] args)
	{
		//Declare array to store numbers
		double[] numbers = new double[10];

		//Variable to store total sum
		double total = 0.0;
		//Index to track array position
		int index = 0;

		//Take input using while loop
		while (true){
			//Ask user for input
			double value = Convert.ToDouble(Console.ReadLine());

			//Stop if value is zero or negative
			if(value <= 0){
				break;
			}

			//Stop if array size reaches limit
			if (index == numbers.Length){
				break;
			}

			//Store value in array
			numbers[index] = value;
			index++;
		}

		//Calculate sum of stored values
		for (int i = 0; i < index; i++){
			total = total + numbers[i];
		}

		//Display total sum
		Console.WriteLine("Sum = " + total);
	}
}
