using System;

public class ArgumentOutOfRangeDemo
{

    //Method to generate ArgumentOutOfRangeException using Substring
    static void GenerateException()
    {
        string name="Aniket";
		Console.WriteLine(name.Substring(4, 10));
    }



    //Method to handle ArgumentOutOfRangeException
    static void HandleException()
    {
        string name="Aniket";
        try
        {
            Console.WriteLine(name.Substring(4, 10));
        }
        catch(ArgumentOutOfRangeException e)
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
