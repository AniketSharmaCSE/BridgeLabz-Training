using System;

public class IndexOutOfRangeDemo
{
    //Method to generate IndexOutOfRangeException using string
    static void GenerateException()
    {
        string text = "Aniket";
        Console.WriteLine(text[10]);
    }


    //Method to handle IndexOutOfRangeException
    static void HandleException()
    {
        string text = "Aniket";
        try
        {
            Console.WriteLine(text[10]);
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
