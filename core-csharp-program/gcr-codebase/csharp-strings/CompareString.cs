using System;

public class CompareString
{
    static bool compare(string a, string b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {

                    return false;

                }
            }
            return true;

        }





        static void Main(string[] args)
        {
            //Take input for both strings
            Console.WriteLine("Enter string 1: ");
            string first = Console.ReadLine();
            Console.WriteLine("Enter string 2: ");
            string second = Console.ReadLine();

            //Compare using user-defined function
            if (compare(first, second))
            {
                Console.WriteLine("Both are equal");
            }

        }

    }
}
