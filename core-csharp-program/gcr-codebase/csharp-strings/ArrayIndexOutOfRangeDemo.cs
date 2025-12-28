using System;

public class ArrayIndexOutOfRangeDemo
{

    //Method to generate IndexOutOfRangeException using array
    static void GenerateException()
    {
        int[] numbers = { 10, 20, 30 };
        Console.WriteLine(numbers[5]);
    }
    //Method to handle IndexOutOfRangeException
    static void HandleException()
    {
        int[] numbers = { 10, 20, 30 };
        try
        {
            Console.WriteLine(numbers[5]);
        }
		
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Exception caught: " + e.Message);
        }
    }
	

    static void Main(string[] args)
    {
        HandleException();    
        GenerateException();
    }
}
