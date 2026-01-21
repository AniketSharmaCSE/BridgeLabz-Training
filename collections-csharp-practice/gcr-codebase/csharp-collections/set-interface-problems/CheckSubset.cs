using System;
using System.Collections.Generic;

class CheckSubset
{
    static void Main(string[] args)
    {
        HashSet<int> small = new HashSet<int>();
        HashSet<int> big = new HashSet<int>();

        Console.Write("Enter number of elements in small set: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of small set:");
        for (int i = 0; i < n1; i++)
        {
            small.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Enter number of elements in big set: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of big set:");
        for (int i = 0; i < n2; i++)
        {
            big.Add(int.Parse(Console.ReadLine()));
        }

        bool result = small.IsSubsetOf(big);

        Console.WriteLine("Is small set a subset of big set? " + result);
    }
}
