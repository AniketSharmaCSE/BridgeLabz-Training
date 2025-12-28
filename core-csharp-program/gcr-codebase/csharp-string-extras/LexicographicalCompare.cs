using System;

public class LexicographicalCompare
{
    //Method to compare two strings lexicographically
    static int CompareStrings(string first, string second)
    {
        //find shorter length
        int minLength = first.Length < second.Length ? first.Length : second.Length;

        //compare characters one by one
        for (int i = 0; i < minLength; i++)
        {
            //return difference as soon as mismatch is found
            if (first[i] != second[i])
            {
                return first[i] - second[i];
            }
        }

        //if all compared characters are same
        return first.Length - second.Length;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter first string: ");
        string first = Console.ReadLine();
        Console.WriteLine("Enter second string: ");
        string second = Console.ReadLine();
        int result = CompareStrings(first, second);
		
        if (result < 0)
        {
            Console.WriteLine(first + " comes before " + second);
        }
        else if (result > 0)
        {
            Console.WriteLine(first + " comes after " + second);
        }
        else
        {
            Console.WriteLine("Both strings are equal");
        }
    }
}
