using System;
using System.Collections.Generic;

class UnionAndIntersection
{
    static void Main()
    {
        HashSet<int> s1 = new HashSet<int>();
        HashSet<int> s2 = new HashSet<int>();

        Console.Write("Enter number of elements in Set 1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++)
        {
            s1.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Enter number of elements in Set 2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++)
        {
            s2.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> union = new HashSet<int>(s1);
        union.UnionWith(s2);

        HashSet<int> intersection = new HashSet<int>(s1);
        intersection.IntersectWith(s2);

        Console.WriteLine("Union:");
        foreach (int x in union)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine("\nIntersection:");
        foreach (int x in intersection)
        {
            Console.Write(x + " ");
        }
    }
}
