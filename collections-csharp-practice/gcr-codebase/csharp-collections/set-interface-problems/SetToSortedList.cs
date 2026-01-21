using System;
using System.Collections.Generic;

class SetToSortedList
{
    static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            set.Add(int.Parse(Console.ReadLine()));
        }

        List<int> list = new List<int>(set);
        list.Sort();

        Console.WriteLine("Sorted elements:");
        foreach (int x in list)
        {
            Console.Write(x + " ");
        }
    }
}
