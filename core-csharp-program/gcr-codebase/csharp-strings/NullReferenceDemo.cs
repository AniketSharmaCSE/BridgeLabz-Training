using System;

public class NullPointExceptionDemo
{
    //Method to generate NullReferenceException
    static void GenerateException()
    {
        string text = null;
        Console.WriteLine("Length: " + text.Length);
    }


    //Method to handle NullReferenceException
    static void HandleException()
    {
        string text = null;
        try
        {
            Console.WriteLine("Length: " + text.Length);
        }
        catch (NullReferenceException e)
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
