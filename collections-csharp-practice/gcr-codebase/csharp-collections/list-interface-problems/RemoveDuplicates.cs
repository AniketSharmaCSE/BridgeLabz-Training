using System;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        foreach (int x in list)
        {
            if (seen.Add(x))
            {
                result.Add(x);
            }
        }

        Console.WriteLine("List after removing duplicates:");
        foreach (int x in result)
        {
            Console.Write(x + " ");
        }
    }
}
