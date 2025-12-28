using System;

public class FormatExceptionDemo
{
	
	//Method to generate FormatException
    static void GenerateException()
    {
        string name = "Aniket";
        int number = int.Parse(name);
        Console.WriteLine(number);
    }
	

    //Method to handle FormatException
    static void HandleException()
    {
        string name = "Aniket";
        try
        {
            int number = int.Parse(name);
            Console.WriteLine(number);
        }
        catch (FormatException e)
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
